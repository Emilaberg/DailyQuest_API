using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _repository;
        private readonly PassKeyVerifier _passKeyVerifier;


        public AnswerController(IAnswerRepository repository, PassKeyVerifier passKeyVerifier)
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

        [HttpPost("{adminPasskey}")]
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

        [HttpDelete("{answerId}/{adminPasskey}")]
        public async Task<IActionResult> DeleteAnswer(string? adminPassKey, int answerId)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.DeleteAsync(answerId);

            return NoContent();
        }
    }
}
