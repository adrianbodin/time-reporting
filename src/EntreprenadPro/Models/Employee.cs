using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EntreprenadPro.Models;

public class Employee : IdentityUser
{
    [Display(Name = "Fullständigt namn")]
    public string FullName { get; set; }

    [Display(Name = "Telefonnummer")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Anställningsdatum")]
    public DateOnly HireDate { get; set; }

    [Display(Name = "Jobbtitel")]
    public string JobTitle { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}

public record AddEmployeeDto
{
    [Required]
    [Display(Name = "Fullständigt namn")]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "E-post")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Lösenord")]
    public string Password { get; set; }

    [Display(Name = "Bekräfta lösenord")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Lösenorden matchar inte.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Telefonnummer")]
    public string PhoneNumber { get; set; }

    [Required]
    [Display(Name = "Jobbtitel")]
    public string JobTitle { get; set; }

    [Display(Name = "Anställningsdatum")]
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

    [Display(Name = "Fullständigt namn")]
    [Required]
    public string FullName { get; set; }

    [Required]
    [Display(Name = "Jobbtitel")]
    public string JobTitle { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Telefonnummer")]
    public string PhoneNumber { get; set; }

    [Required]
    [Display(Name = "Anställningsdatum")]
    [DataType(DataType.Date)]
    public DateTime HireDate { get; set; }
};

public record EmployeeTableDto(string Id, string FullName, string JobTitle, DateTime HireDate);