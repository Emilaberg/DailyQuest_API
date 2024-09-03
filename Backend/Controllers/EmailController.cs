using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;
namespace Backend.Controllers;


[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly IGenericRepository<EmailModel> _repository;
    private readonly PassKeyVerifier _passKeyVerifier;

    public EmailController(IGenericRepository<EmailModel> repository, PassKeyVerifier passKeyVerifier)
    {
        _repository = repository;
        _passKeyVerifier = passKeyVerifier;
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
        if (EmailId <= 0) return BadRequest();

        EmailModel? email = await _repository.GetByIdAsync(EmailId);
        if (email == null)
        {
            return NotFound();
        }

        return Ok(email);
    }

    [HttpPost("{adminPassKey}")]
    public async Task<ActionResult> PostEmail(string? adminPassKey, EmailModel? email)
    {
        if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
        await _repository.AddAsync(email);
        return Ok($"The Email: {email.Email} was added.");
    }


    [HttpPut("{adminPassKey}")]
    public async Task<IActionResult> PutEmail(string? adminPassKey, EmailModel? email)
    {
        if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }


        await _repository.UpdateAsync(email);
        return NoContent();

    }
}