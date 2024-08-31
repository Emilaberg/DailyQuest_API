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


        [HttpGet("{AnswerId}")]
        public async Task<ActionResult<AnswerModel>> GetAnswer(int AnswerId)
        {
            var answer = await _repository.GetByIdAsync(AnswerId);

            if (answer == null)
            {
                return NotFound();
            }
            return Ok(answer);
        }

        [HttpPost("{answer}")]
        public async Task PostAnswer(AnswerModel answer)
        {

            await _repository.AddAsync(answer);

        }


        [HttpPut("{AnswerId}")]
        public async Task<IActionResult> PutAnswer(AnswerModel AnswerId)
        {
            await _repository.UpdateAsync(AnswerId);
            return NoContent();
        }

        [HttpDelete("{AnswerId}")]
        public async Task<IActionResult> DeleteAnswer(int AnswerId)
        {
            await _repository.DeleteAsync(AnswerId);

            return NoContent();
        }
    }
}
