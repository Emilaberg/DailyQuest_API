using DataBase.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DbModels;

namespace Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketRepository _ticketRepository;
    public TicketController(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    [HttpPost]
    public async Task<IActionResult> PostTicket(TicketModel ticket)
    {
        await _ticketRepository.AddAsync(ticket);
        return Ok("Ticket saved successfully.");
    }

}

