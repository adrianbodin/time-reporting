namespace TimeReporting.Models;

public class WorkType
{
    public string Id { get; set; }

    public string Name { get; set; }

    public int HourlyRate { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}