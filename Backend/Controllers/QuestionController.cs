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

        [HttpGet("{AnswerId}")]
        public async Task<ActionResult<QuestionModel>> GetQuestion(int id)
        {
            var question = await _repository.GetByIdAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        [HttpPost]
        public async Task<ActionResult<QuestionModel>> PostQuestion(QuestionModel question)
        {
            await _repository.AddAsync(question);
            return CreatedAtAction(nameof(GetQuestion), new { id = question.QuestionId }, question);
        }

        [HttpPut("{AnswerId}")]
        public async Task<IActionResult> PutQuestion(int id, QuestionModel question)
        {
            if (id != question.QuestionId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(question);
            return NoContent();
        }

        [HttpDelete("{AnswerId}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
