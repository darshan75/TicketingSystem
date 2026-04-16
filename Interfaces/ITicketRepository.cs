
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Interfaces;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task AddAsync(Ticket ticket);

    Task<Ticket?> GetByIdAsync(string id);
Task UpdateAsync(Ticket ticket);
}
