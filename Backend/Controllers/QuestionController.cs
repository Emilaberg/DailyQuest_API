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
        public async Task<ActionResult<QuestionModel>> GetQuestion(int questionId)
        {
            var question = await _repository.GetByIdAsync(questionId);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        [HttpPost]
        public async Task PostQuestion(QuestionModel question)
        {
            await _repository.AddAsync(question);
            //return CreatedAtAction(nameof(GetQuestion), new { id = question.QuestionId }, question);
        }

        [HttpPut("{QuestionId}")]
        public async Task PutQuestion(int id, QuestionModel question)
        {
            if (id != question.QuestionId)
            {
                return;
            }

            await _repository.UpdateAsync(question);
            return;
        }

        [HttpDelete("{QuestionId}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
