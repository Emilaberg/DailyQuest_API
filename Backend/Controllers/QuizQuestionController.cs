using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuestionController : ControllerBase
    {
        private readonly IQuizQuestionRepository _repository;

        public QuizQuestionController(IQuizQuestionRepository repository)
        {
            _repository = repository;
        }

        // GET: api/QuizQuestion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizQuestion>>> GetQuizQuestions()
        {
            var quizQuestions = await _repository.GetAllAsync();
            return Ok(quizQuestions);
        }

        // GET: api/QuizQuestion/5/5
        [HttpGet("{quizId}/{questionId}")]
        public async Task<ActionResult<QuizQuestion>> GetQuizQuestion(int quizId, int questionId)
        {
            var quizQuestion = await _repository.GetByQuizAndQuestionIdAsync(quizId, questionId);
            if (quizQuestion == null) return NotFound();
            return Ok(quizQuestion);
        }

        // POST: api/QuizQuestion
        [HttpPost]
        public async Task<ActionResult<QuizQuestion>> PostQuizQuestion(QuizQuestion quizQuestion)
        {
            await _repository.AddAsync(quizQuestion);
            return CreatedAtAction(nameof(GetQuizQuestion), new { quizId = quizQuestion.QuizId, questionId = quizQuestion.QuestionId }, quizQuestion);
        }

        // PUT: api/QuizQuestion/5/5
        [HttpPut("{quizId}/{questionId}")]
        public async Task<IActionResult> PutQuizQuestion(int quizId, int questionId, QuizQuestion quizQuestion)
        {
            if (quizId != quizQuestion.QuizId || questionId != quizQuestion.QuestionId)
                return BadRequest();

            await _repository.UpdateAsync(quizQuestion);
            return NoContent();
        }

        // DELETE: api/QuizQuestion/5/5
        [HttpDelete("{quizId}/{questionId}")]
        public async Task<IActionResult> DeleteQuizQuestion(int quizId, int questionId)
        {
            var compositeKey = new { quizId, questionId };
            await _repository.DeleteAsync(compositeKey);
            return NoContent();
        }
    }
}