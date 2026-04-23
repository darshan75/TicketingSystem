using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketingSystemMongo.Models;

public class Ticket
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string Priority { get; set; } = "Low"; // Low, Medium, High
    public string Status { get; set; } = "Open"; // Open, InProgress, Closed

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public string CreatedByUserId { get; set; } = string.Empty;
    public string? AssignedToUserId { get; set; }

    public bool IsDeleted { get; set; } = false;
    public DateTime UpdatedDate { get; set; }
}