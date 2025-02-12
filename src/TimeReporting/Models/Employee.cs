using System.ComponentModel.DataAnnotations;
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

public record AddEmployeeDto
{
    [Required]
    [Display(Name = "Full Name")]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required]
    [Display(Name = "Job Title")]
    public string JobTitle { get; set; }

    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    public DateOnly HireDate { get; set; }
}

public record EmployeeDetailsDto(
    string Id,
    string FullName,
    string Email,
    string PhoneNumber,
    DateOnly? HireDate,
    string JobTitle,
    List<TimeEntryDetailsDto> RecentTimeEntries
);

public record EditEmployeeDto
{
    public string Id { get; set; }

    [Display(Name = "Full Name")]
    [Required]
    public string FullName { get; set; }

    [Required]
    [Display(Name = "Job Title")]
    public string JobTitle { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required]
    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    public DateTime HireDate { get; set; }
};

public record EmployeeTableDto(string Id, string FullName, string JobTitle, DateTime HireDate);