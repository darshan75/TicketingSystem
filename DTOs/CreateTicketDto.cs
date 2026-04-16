public class CreateTicketDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = "Low";
    public string CreatedByUserId { get; set; } = string.Empty;
}