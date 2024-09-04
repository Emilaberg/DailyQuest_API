using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaTagController : ControllerBase
    {
        private readonly IMetaTagRepository _repository;
        private readonly PassKeyVerifier _passKeyVerifier;

        public MetaTagController(IMetaTagRepository repository, PassKeyVerifier passKeyVerifier)
        {
            _repository = repository;
            _passKeyVerifier = passKeyVerifier;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaTagModel>>> GetMetaTags()
        {
            var metaTags = await _repository.GetAllAsync();
            return Ok(metaTags);
        }


        [HttpGet("{metaTagId}")]
        public async Task<ActionResult<MetaTagModel>> GetMetaTag(int metaTagId)
        {
            var metaTag = await _repository.GetByIdAsync(metaTagId);

            if (metaTag == null)
            {
                return NotFound();
            }
            return Ok(metaTag);
        }

        [HttpPost("{adminPassKey}")]
        public async Task<IActionResult> PostMetaTag(string? adminPassKey, MetaTagModel? metaTag)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.AddAsync(metaTag);
            return Ok($"The MetaTag: {metaTag.TagName} was added.");
        }

        [HttpPut("{adminPassKey}")]
        public async Task<IActionResult> PutMetaTag(string? adminPassKey, MetaTagModel metaTag)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.UpdateAsync(metaTag);
            return NoContent();
        }


        [HttpDelete("{metaTagId}/{adminPassKey}")]
        public async Task<IActionResult> DeleteMetaTag(string? adminPassKey, int metaTagId)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            await _repository.DeleteAsync(metaTagId);

            return NoContent();
        }
    }
}
