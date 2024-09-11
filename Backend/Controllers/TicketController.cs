using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketRepository _ticketRepository;
    private readonly PassKeyVerifier _passKeyVerifier;
    public TicketController(ITicketRepository ticketRepository, PassKeyVerifier passKeyVerifier)
    {
        _ticketRepository = ticketRepository;
        _passKeyVerifier = passKeyVerifier;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TicketModel>>> GetTickets()
    {
        var tickets = await _ticketRepository.GetAllAsync();
        return Ok(tickets);
    }

    [HttpGet("{ticketId}")]
    public async Task<ActionResult<TicketModel?>> GetTicket(int ticketId)
    {
        return Ok(await _ticketRepository.GetByIdAsync(ticketId));
    }


    [HttpPost("{adminPassKey}")]
    public async Task<IActionResult> PostTicket(string? adminPassKey, string email, string subject, string message)
    {
        if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
        TicketModel ticket = new TicketModel
        {
            Email = email,
            Subject = subject,
            Message = message,
            TimeStamp = DateTime.Now
        };
        await _ticketRepository.AddAsync(ticket);
        return Ok("Ticket saved successfully.");
    }

    [HttpPut("{adminPassKey}")]
    public async Task<IActionResult> PutTicket(string? adminPassKey, string email, string subject, string message)
    {
        if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
        TicketModel ticket = new TicketModel
        {
            Email = email,
            Subject = subject,
            Message = message,
            TimeStamp = DateTime.Now
        };
        await _ticketRepository.UpdateAsync(ticket);
        return Ok("Ticket updated successfully.");
    }

    [HttpDelete("{adminPassKey}")]
    public async Task<IActionResult> DeleteTicket(string? adminPassKey, int ticketId)
    {
        if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
        await _ticketRepository.DeleteAsync(ticketId);
        return Ok("Ticket deleted successfully.");
    }
}

