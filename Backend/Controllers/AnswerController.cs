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
        private readonly PassKeyVerifier _passKeyVerifier;

        public AnswerController(IGenericRepository<AnswerModel> repository, PassKeyVerifier passKeyVerifier)
        {
            _repository = repository;
            _passKeyVerifier = passKeyVerifier;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerModel>>> GetAnswers()
        {
            var answers = await _repository.GetAllAsync();
            return Ok(answers);
        }


        [HttpGet("{AnswerId}")]
        public async Task<ActionResult<AnswerModel>> GetAnswer(int AnswerId)
        {
            var answer = await _repository.GetByIdAsync(AnswerId);

            if (answer == null)
            {
                return NotFound();
            }
            return Ok(answer);
        }

        [HttpPost("{answer}")]
        public async Task PostAnswer(AnswerModel answer)
        {

            await _repository.AddAsync(answer);

        }


        [HttpPut("{Answer}")]
        public async Task<IActionResult> PutAnswer(AnswerModel Answer)
        {
            await _repository.UpdateAsync(Answer);
            return NoContent();
        }

        [HttpDelete("{AnswerId}")]
        public async Task<IActionResult> DeleteAnswer(int AnswerId)
        {
            await _repository.DeleteAsync(AnswerId);

            return NoContent();
        }
    }
}
