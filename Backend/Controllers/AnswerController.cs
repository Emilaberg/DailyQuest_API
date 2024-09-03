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

        [HttpPost("{adminPassKey}")]
        public async Task<ActionResult> PostAnswer(string? adminPasskey, AnswerModel answer)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }

            await _repository.AddAsync(answer);
            return Ok($"The Answer: {answer.Answer} was added.");
        }


        [HttpPut("{adminPasskey}")]
        public async Task<IActionResult> PutAnswer(string? adminPasskey, AnswerModel Answer)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.UpdateAsync(Answer);
            return NoContent();
        }

        [HttpDelete("{adminPasskey}")]
        public async Task<IActionResult> DeleteAnswer(string? adminPassKey, int AnswerId)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.DeleteAsync(AnswerId);

            return NoContent();
        }
    }
}
