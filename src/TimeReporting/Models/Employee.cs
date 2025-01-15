using Microsoft.AspNetCore.Identity;

namespace TimeReporting.Models;

public class Employee : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}