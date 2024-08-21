using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Quiz
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizModel>>> GetQuizModels()
        {
            return await _context.QuizModels.ToListAsync();
        }

        // GET: api/Quiz/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuizModel>> GetQuizModel(int id)
        {
            var quizModel = await _context.QuizModels.FindAsync(id);

            if (quizModel == null)
            {
                return NotFound();
            }

            return quizModel;
        }

        // POST: api/Quiz
        [HttpPost]
        public async Task<ActionResult<QuizModel>> PostQuizModel(QuizModel quizModel)
        {
            _context.QuizModels.Add(quizModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuizModel), new { id = quizModel.QuizId }, quizModel);
        }

        // PUT: api/Quiz/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuizModel(int id, QuizModel quizModel)
        {
            if (id != quizModel.QuizId)
            {
                return BadRequest();
            }

            _context.Entry(quizModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Quiz/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizModel(int id)
        {
            var quizModel = await _context.QuizModels.FindAsync(id);
            if (quizModel == null)
            {
                return NotFound();
            }

            _context.QuizModels.Remove(quizModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuizModelExists(int id)
        {
            return _context.QuizModels.Any(e => e.QuizId == id);
        }
    }
}
