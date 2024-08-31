using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;
namespace Backend.Controllers;


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
    public async Task<ActionResult<EmailModel>> GetEmail(int EmailId)
    {
        var email = await _repository.GetByIdAsync(EmailId);
        if (email == null)
        {
            return NotFound();
        }

        return Ok(email);
    }

    [HttpPost]
    public async Task PostEmail(EmailModel email)
    {
        await _repository.AddAsync(email);
        //return CreatedAtAction(nameof(GetEmail), new { id = email.EmailId }, email);
    }


    [HttpPut("{email}")]
    public async Task<IActionResult> PutEmail(EmailModel email)
    {
        //if (id != email.EmailId)
        //{
        //    return BadRequest();
        //}


        await _repository.UpdateAsync(email);
        return NoContent();

    }
}