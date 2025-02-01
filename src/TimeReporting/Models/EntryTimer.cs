namespace TimeReporting.Models;

public class EntryTimer
{
    public string Id { get; set; }

    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public string? TimeEntryId { get; set; }
    public TimeEntry TimeEntry { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}