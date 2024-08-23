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

        [HttpGet("{id}")]
        public async Task<ActionResult<QuizModel>> GetQuizModel(int id)
        {
            var quizModel = await _repository.GetByIdAsync(id);
            if (quizModel == null)
            {
                return NotFound();
            }
            return Ok(quizModel);
        }

        [HttpPost]
        public async Task<ActionResult<QuizModel>> PostQuizModel(QuizModel quizModel)
        {
            await _repository.AddAsync(quizModel);
            return CreatedAtAction(nameof(GetQuizModel), new { id = quizModel.QuizModelId }, quizModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuizModel(int id, QuizModel quizModel)
        {
            if (id != quizModel.QuizModelId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(quizModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizModel(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
