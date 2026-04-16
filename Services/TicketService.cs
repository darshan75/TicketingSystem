
using TicketingSystemMongo.Interfaces;
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _repo;

    public TicketService(ITicketRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    // public async Task<Ticket> CreateAsync(Ticket ticket)
    // {
    //     await _repo.AddAsync(ticket);
    //     return ticket;
    // }
    public async Task<Ticket?> GetByIdAsync(string id)
{
    return await _repo.GetByIdAsync(id);
}

public async Task<bool> UpdateAsync(string id, UpdateTicketDto dto)
{
    var ticket = await _repo.GetByIdAsync(id);
    if (ticket == null) return false;

    ticket.Status = dto.Status;
    ticket.Priority = dto.Priority;

    await _repo.UpdateAsync(ticket);
    return true;
}

public async Task<bool> DeleteAsync(string id)
{
    var ticket = await _repo.GetByIdAsync(id);
    if (ticket == null) return false;

    ticket.IsDeleted = true;
    await _repo.UpdateAsync(ticket);
    return true;
}

private readonly ILogger<TicketService> _logger;

public TicketService(ITicketRepository repo, ILogger<TicketService> logger)
{
    _repo = repo;
    _logger = logger;
}

public async Task<Ticket> CreateAsync(Ticket ticket)
{
    _logger.LogInformation("Creating ticket: {Title}", ticket.Title);

    await _repo.AddAsync(ticket);

    return ticket;
}
}
