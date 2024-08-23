using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionMetaTagController : ControllerBase
    {
        private readonly IGenericRepository<QuestionMetaTag> _repository;

        public QuestionMetaTagController(IGenericRepository<QuestionMetaTag> repository)
        {
            _repository = repository;
        }

        // GET: api/QuestionMetaTag
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionMetaTag>>> GetQuestionMetaTags()
        {
            var metaTags = await _repository.GetAllAsync();
            return Ok(metaTags);
        }

        // GET: api/QuestionMetaTag/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionMetaTag>> GetQuestionMetaTag(int id)
        {
            var metaTag = await _repository.GetByIdAsync(id);
            if (metaTag == null)
            {
                return NotFound();
            }
            return Ok(metaTag);
        }

        // POST: api/QuestionMetaTag
        [HttpPost]
        public async Task<ActionResult<QuestionMetaTag>> PostQuestionMetaTag(QuestionMetaTag metaTag)
        {
            await _repository.AddAsync(metaTag);
            return CreatedAtAction(nameof(GetQuestionMetaTag), new { id = metaTag.MetaTagId }, metaTag);
        }

        // PUT: api/QuestionMetaTag/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestionMetaTag(int id, QuestionMetaTag metaTag)
        {
            if (id != metaTag.MetaTagId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(metaTag);
            return NoContent();
        }

        // DELETE: api/QuestionMetaTag/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestionMetaTag(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
