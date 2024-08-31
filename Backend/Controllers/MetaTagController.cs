using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaTagController : ControllerBase
    {
        private readonly IGenericRepository<MetaTagModel> _repository;

        public MetaTagController(IGenericRepository<MetaTagModel> repository)
        {
            _repository = repository;
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

        [HttpPost]
        public async Task PostMetaTag(MetaTagModel metaTag)
        {
            await _repository.AddAsync(metaTag);

        }

        [HttpPut("{metaTag}")]
        public async Task<IActionResult> PutMetaTag(MetaTagModel metaTag)
        {



            await _repository.UpdateAsync(metaTag);
            return NoContent();
        }


        [HttpDelete("{metaTagId}")]
        public async Task<IActionResult> DeleteMetaTag(int metaTagId)
        {
            await _repository.DeleteAsync(metaTagId);

            return NoContent();
        }
    }
}
