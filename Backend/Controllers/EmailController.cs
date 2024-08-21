using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;
namespace Backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {

        private readonly AppDbContext _context;

        public EmailController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Email
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailModel>>> GetEmailModels()
        {
            return await _context.EmailModels.ToListAsync();
        }

        // GET: api/Email/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmailModel>> GetEmailModel(int id)
        {
            var emailModel = await _context.EmailModels.FindAsync(id);

            if (emailModel == null)
            {
                return NotFound();
            }

            return emailModel;
        }

        // POST: api/Email
        [HttpPost]
        public async Task<ActionResult<EmailModel>> PostEmailModel(EmailModel emailModel)
        {
            _context.EmailModels.Add(emailModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmailModel), new { id = emailModel.EmailId }, emailModel);
        }

        // PUT: api/Email/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmailModel(int id, EmailModel emailModel)
        {
            if (id != emailModel.EmailId)
            {
                return BadRequest();
            }

            _context.Entry(emailModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmailModelExists(id))
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

        // DELETE: api/Email/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmailModel(int id)
        {
            var emailModel = await _context.EmailModels.FindAsync(id);
            if (emailModel == null)
            {
                return NotFound();
            }

            _context.EmailModels.Remove(emailModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmailModelExists(int id)
        {
            return _context.EmailModels.Any(e => e.EmailId == id);
        }
    }
}
