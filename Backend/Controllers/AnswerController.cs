﻿using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IGenericRepository<AnswerModel> _repository;

        public AnswerController(IGenericRepository<AnswerModel> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerModel>>> GetAnswers()
        {
            var answers = await _repository.GetAllAsync();
            return Ok(answers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AnswerModel>> GetAnswer(int id)
        {
            var answer = await _repository.GetByIdAsync(id);
            if (answer == null)
            {
                return NotFound();
            }
            return Ok(answer);
        }

        [HttpPost]
        public async Task<ActionResult<AnswerModel>> PostAnswer(AnswerModel answer)
        {
            await _repository.AddAsync(answer);
            return CreatedAtAction(nameof(GetAnswer), new { id = answer.AnswerId }, answer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnswer(int id, AnswerModel answer)
        {
            if (id != answer.AnswerId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(answer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
