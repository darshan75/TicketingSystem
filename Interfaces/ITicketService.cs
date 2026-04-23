
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Interfaces;

public interface ITicketService
{
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<Ticket?> GetByIdAsync(string id);
    Task UpdateAsync(string id, UpdateTicketDto dto);
    Task<bool> DeleteAsync(string id);
}
