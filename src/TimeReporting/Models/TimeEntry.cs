using Microsoft.Build.Framework;

namespace TimeReporting.Models;

public class TimeEntry
{
    public string Id { get; set; }

    public string ProjectId { get; set; }
    public Project Project { get; set; }

    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public double Hours { get; set; }

    public DateOnly Date { get; set; }

    public string Description { get; set; }

    public double HourlyRate { get; set; }

    public string WorkTypeId { get; set; }
    public WorkType WorkType { get; set; }
}