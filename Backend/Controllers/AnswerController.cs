using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IGenericRepository<AnswerModel> _repository;

        public AnswerController(IGenericRepository<AnswerModel> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerModel>>> GetAnswers()
        {
            var answers = await _repository.GetAllAsync();
            return Ok(answers);
        }

        [HttpGet("{answerId}")]
        public async Task<ActionResult<AnswerModel>> GetAnswer(int answerId)
        {
            var answer = await _repository.GetByIdAsync(answerId);
            if (answer == null)
            {
                return NotFound();
            }
            return Ok(answer);
        }

        [HttpPost]
        public async Task PostAnswer(AnswerModel answer)
        {

            await _repository.AddAsync(answer);

        }

        [HttpPut("{answerId}")]
        public async Task<IActionResult> PutAnswer(AnswerModel answer)
        {
            //if (answer.AnswerId)
            //{
            //    return BadRequest();
            //}

            await _repository.UpdateAsync(answer);
            return NoContent();
        }

        [HttpDelete("{answerId}")]
        public async Task<IActionResult> DeleteAnswer(int answerId)
        {
            await _repository.DeleteAsync(answerId);
            return NoContent();
        }
    }
}
