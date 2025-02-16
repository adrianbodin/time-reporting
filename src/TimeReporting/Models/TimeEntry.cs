using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

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

public record ReadTimeEntryDto(string Id,string Project, double Hours, string Description, DateOnly Date, string WorkType, string EmployeeName, string EmployeeId);

public record TimeEntryDetailsDto(
    string ProjectName,
    double Hours,
    DateOnly Date,
    string WorkType
);

public record EditTimeEntryDto
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string ProjectId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required]
    public string Description { get; set; }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateOnly Date { get; set; }

    [Required]
    public string WorkTypeId { get; set; }
}