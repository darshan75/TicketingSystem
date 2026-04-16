
using MongoDB.Driver;
using TicketingSystemMongo.Models;

namespace TicketingSystemMongo.Data;

public class MongoDbContext
{
    private readonly IMongoDatabase _db;

    public MongoDbContext(IConfiguration config)
    {
        var client = new MongoClient(config["MongoDbSettings:ConnectionString"]);
        _db = client.GetDatabase(config["MongoDbSettings:DatabaseName"]);
    }

    public IMongoCollection<Ticket> Tickets => _db.GetCollection<Ticket>("Tickets");
    public IMongoCollection<User> Users => _db.GetCollection<User>("Users");
}
