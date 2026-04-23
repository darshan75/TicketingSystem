
using MongoDB.Driver;
using TicketingSystemMongo.Data;
using TicketingSystemMongo.Interfaces;
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly IMongoCollection<Ticket> _tickets;

    public TicketRepository(MongoDbContext context)
    {
        _tickets = context.Tickets;
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _tickets.Find(_ => true).ToListAsync();
    }

    public async Task AddAsync(Ticket ticket)
    {
        await _tickets.InsertOneAsync(ticket);
    }

    public async Task<Ticket?> GetByIdAsync(string id)
    {
        return await _tickets.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(Ticket ticket)
    {
        await _tickets.ReplaceOneAsync(x => x.Id == ticket.Id, ticket);
    }

    public async Task UpsertAsync(
    FilterDefinition<Ticket> filter,
    UpdateDefinition<Ticket> update)
    {
    await _tickets.UpdateOneAsync(
        filter,
        update,
        new UpdateOptions { IsUpsert = true }
    );
    }
}
