
using TicketingSystemMongo.Models;
using MongoDB.Driver;

namespace TicketingSystemMongo.Interfaces;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetAllAsync();
    Task AddAsync(Ticket ticket);

    Task<Ticket?> GetByIdAsync(string id);
    Task UpdateAsync(Ticket ticket);
    Task UpsertAsync(
        FilterDefinition<Ticket> filter,
        UpdateDefinition<Ticket> update
    );
}
