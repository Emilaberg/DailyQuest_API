﻿using DataBase.Repositories.Interfaces;
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

        [HttpGet("{MetaTagId}")]
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
            //return CreatedAtAction(nameof(GetMetaTag), new { id = metaTag.MetaTagId }, metaTag);
        }

        [HttpPut("{MetaTagId}")]
        public async Task<IActionResult> PutMetaTag(int id, MetaTagModel metaTag)
        {
            if (id != metaTag.MetaTagId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(metaTag);
            return NoContent();
        }

        [HttpDelete("{MetaTagId}")]
        public async Task<IActionResult> DeleteMetaTag(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
