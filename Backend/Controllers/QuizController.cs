using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _repository;
        private readonly PassKeyVerifier _passKeyVerifier;
        private readonly IQuestionRepository _questionRepo;
        private readonly IQuizQuestionRepository _quizQuestionRepo;

        public QuizController(IQuizRepository repository,
            PassKeyVerifier passKeyVerifier,
            IQuestionRepository questionRepo,
            IQuizQuestionRepository quizQuestionRepo)
        {
            _repository = repository;
            _passKeyVerifier = passKeyVerifier;
            _questionRepo = questionRepo;
            _quizQuestionRepo = quizQuestionRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizModel>>> GetQuizModels()
        {
            var quizModels = await _repository.GetAllAsync();
            return Ok(quizModels);
        }

        [HttpGet("{QuizId}")]
        public async Task<ActionResult<QuizModel?>> GetQuizModel(int QuizId)
        {
            return Ok(await _repository.GetByIdAsync_EagerLoading(QuizId));

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

        [HttpDelete("{QuizId}/{adminPassKey}")]
        public async Task<IActionResult> DeleteQuizModel(string? adminPassKey, int QuizId)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.DeleteAsync(QuizId);
            return NoContent();
        }
    }
}
