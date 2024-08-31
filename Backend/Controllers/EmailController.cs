﻿using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;
namespace Backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IGenericRepository<EmailModel> _repository;

        public EmailController(IGenericRepository<EmailModel> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailModel>>> GetEmails()
        {
            var emails = await _repository.GetAllAsync();
            return Ok(emails);
        }

        [HttpGet("{EmailId}")]
        public async Task<ActionResult<EmailModel>> GetEmail(int emailId)
        {
            var email = await _repository.GetByIdAsync(emailId);
            if (email == null)
            {
                return NotFound();
            }
            return Ok(email);
        }

        [HttpPost]
        public async Task<ActionResult<EmailModel>> PostEmail(EmailModel email)
        {
            await _repository.AddAsync(email);
            return CreatedAtAction(nameof(GetEmail), new { id = email.EmailId }, email);
        }

        [HttpPut("{EmailId}")]
        public async Task<IActionResult> PutEmail(int id, EmailModel email)
        {
            if (id != email.EmailId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(email);
            return NoContent();
        }

        [HttpDelete("{EmailId}")]
        public async Task<IActionResult> DeleteEmail(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
