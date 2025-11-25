using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EntreprenadPro.Models;

public enum TimeEntryType
{
    [Display(Name = "Debiterbar")] Debitable,
    [Display(Name = "Intern")] Internal,
    [Display(Name = "Semester")] Vacation,
    [Display(Name = "Sjuk")] Sick,
    [Display(Name = "VAB")] Vab
}

public class TimeEntry
{
    public string Id { get; set; }

    public int? ProjectId { get; set; }
    public Project? Project { get; set; }

    public string? EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public double Hours { get; set; }

    public DateOnly Date { get; set; }

    public string Description { get; set; }

    public double HourlyRate { get; set; }

    public string? WorkTypeId { get; set; }
    public WorkType? WorkType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public TimeEntryType Type { get; set; }
}

public record ReadTimeEntryDto(
    string Id,
    string Project,
    double Hours,
    string Description,
    DateOnly Date,
    string WorkType,
    string EmployeeName,
    string EmployeeId,
    TimeEntryType Type);

public record TimeEntryDetailsDto(
    string ProjectName,
    double Hours,
    DateOnly Date,
    string WorkType
);

public record EditTimeEntryDto
{
    [Required] public string Id { get; set; }

    [Required] public int? ProjectId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required] public string Description { get; set; }

    [BindProperty(SupportsGet = true)]
    [DataType(DataType.Date)]
    public DateOnly Date { get; set; }

    [Required] public string WorkTypeId { get; set; }
}