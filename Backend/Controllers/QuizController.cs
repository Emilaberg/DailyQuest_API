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

        public QuizController(IGenericRepository<QuizModel> repository)
        {
            _repository = repository;
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

        [HttpPost]
        public async Task PostQuizModel(QuizModel quizModel)
        {
            await _repository.AddAsync(quizModel);
            //return CreatedAtAction(nameof(GetQuizModel), new { id = quizModel.QuizId }, quizModel);
        }

        [HttpPut("{QuizId}")]
        public async Task<IActionResult> PutQuizModel(QuizModel QuizId)
        {
            //if (id != quizModel.QuizId)
            //{
            //    return BadRequest();
            //}

            await _repository.UpdateAsync(QuizId);
            return NoContent();
        }

        [HttpDelete("{QuizId}")]
        public async Task<IActionResult> DeleteQuizModel(int QuizId)
        {
            await _repository.DeleteAsync(QuizId);
            return NoContent();
        }
    }
}
