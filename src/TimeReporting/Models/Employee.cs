using Microsoft.AspNetCore.Identity;

namespace TimeReporting.Models;

public class Employee : IdentityUser
{
    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public DateOnly HireDate { get; set; }

    public string JobTitle { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}