using System.ComponentModel.DataAnnotations;

namespace TimeReporting.Models;

public class Project
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}

public record AddProjectDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(500)]
    public string Description { get; set; }

    public string CustomerId { get; set; }
}