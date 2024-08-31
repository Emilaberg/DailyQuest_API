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

        public QuestionController(IGenericRepository<QuestionModel> repository)
        {
            _repository = repository;
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


        [HttpPost("{question}")]
        public async Task PostQuestion(QuestionModel question)
        {
            await _repository.AddAsync(question);
        }

        [HttpPut("{question}")]
        public async Task PutQuestion(QuestionModel question)
        {



            await _repository.UpdateAsync(question);
        }


        [HttpDelete("{questionId}")]
        public async Task<IActionResult> DeleteQuestion(int questionId)
        {
            await _repository.DeleteAsync(questionId);

            return NoContent();
        }
    }
}
