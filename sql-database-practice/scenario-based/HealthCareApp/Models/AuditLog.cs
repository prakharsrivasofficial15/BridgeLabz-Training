namespace HealthCareApp.Models;

public class AuditLog
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ActionType { get; set; }
    public string TableName { get; set; }
    public int RecordId { get; set; }
    public DateTime Timestamp { get; set; }
}
