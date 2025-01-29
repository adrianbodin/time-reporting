using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TimeReporting.Models;

public class Employee : IdentityUser
{
    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? JobTitleId { get; set; }
    public JobTitle JobTitle { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}