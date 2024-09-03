using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IGenericRepository<QuizModel> _repository;
        private readonly PassKeyVerifier _passKeyVerifier;

        public QuizController(IGenericRepository<QuizModel> repository, PassKeyVerifier passKeyVerifier)
        {
            _repository = repository;
            _passKeyVerifier = passKeyVerifier;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizModel>>> GetQuizModels()
        {
            var quizModels = await _repository.GetAllAsync();
            return Ok(quizModels);
        }

        [HttpGet("{QuizId}")]
        public async Task<ActionResult<QuizModel>> GetQuizModel(int QuizId)
        {
            var quizModel = await _repository.GetByIdAsync(QuizId);
            if (quizModel == null)
            {
                return NotFound();
            }
            return Ok(quizModel);
        }


        [HttpPost("{adminPassKey}")]
        public async Task<IActionResult> PostQuizModel(string? adminPassKey, QuizModel Quiz)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.AddAsync(Quiz);
            return Ok($"The Quiz: {Quiz.QuizName} was added.");
        }

        [HttpPut("{adminPassKey}")]
        public async Task<IActionResult> PutQuizModel(string? adminPassKey, QuizModel Quiz)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.UpdateAsync(Quiz);

            return NoContent();
        }

        [HttpDelete("{adminPassKey}")]
        public async Task<IActionResult> DeleteQuizModel(string? adminPassKey, int QuizId)
        {
            await _repository.DeleteAsync(QuizId);
            return NoContent();
        }
    }
}
