using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaTagController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MetaTagController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaTagModel>>> GetMetaTags()
        {
            return await _context.MetaTags.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MetaTagModel>> GetMetaTag(int id)
        {
            var metaTag = await _context.MetaTags.FindAsync(id);

            if (metaTag == null)
            {
                return NotFound();
            }

            return metaTag;
        }

        [HttpPost]
        public async Task<ActionResult<MetaTagModel>> PostMetaTag(MetaTagModel metaTag)
        {
            _context.MetaTags.Add(metaTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMetaTag), new { id = metaTag.MetaTagId }, metaTag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetaTag(int id, MetaTagModel metaTag)
        {
            if (id != metaTag.MetaTagId)
            {
                return BadRequest();
            }

            _context.Entry(metaTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetaTagExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetaTag(int id)
        {
            var metaTag = await _context.MetaTags.FindAsync(id);
            if (metaTag == null)
            {
                return NotFound();
            }

            _context.MetaTags.Remove(metaTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MetaTagExists(int id)
        {
            return _context.MetaTags.Any(e => e.MetaTagId == id);
        }
    }
}
