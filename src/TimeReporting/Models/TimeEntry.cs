using Microsoft.Build.Framework;

namespace TimeReporting.Models;

public class TimeEntry
{
    public string Id { get; set; }

    public string CustomerId { get; set; }
    public Customer Customer { get; set; }

    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public double Hours { get; set; }

    public DateOnly Date { get; set; }

    public string Description { get; set; }

}