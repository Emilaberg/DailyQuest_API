using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IGenericRepository<QuestionModel> _repository;
        private readonly PassKeyVerifier _passKeyVerifier;
        public QuestionController(IGenericRepository<QuestionModel> repository, PassKeyVerifier passKeyVerifier)
        {
            _repository = repository;
            _passKeyVerifier = passKeyVerifier;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionModel>>> GetQuestions()
        {
            var questions = await _repository.GetAllAsync();
            return Ok(questions);
        }

        [HttpGet("{QuestionId}")]
        public async Task<ActionResult<QuestionModel>> GetQuestion(int QuestionId)
        {
            var question = await _repository.GetByIdAsync(QuestionId);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }


        [HttpPost("{adminPassKey}")]
        public async Task<IActionResult> PostQuestion(string? adminPassKey, QuestionModel question)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.AddAsync(question);
            return Ok($"The Question: {question.Question} was added.");
        }

        [HttpPut("{adminPassKey}")]
        public async Task<IActionResult> PutQuestion(string? adminPassKey, QuestionModel question)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.UpdateAsync(question);
            return Ok("The value was edited");
        }


        [HttpDelete("{adminPassKey}")]
        public async Task<IActionResult> DeleteQuestion(string? adminPassKey, int questionId)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.DeleteAsync(questionId);
            return NoContent();
        }
    }
}
