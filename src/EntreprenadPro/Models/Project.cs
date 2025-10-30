using System.ComponentModel.DataAnnotations;

namespace EntreprenadPro.Models;

public enum ProjectStatus
{
    [Display(Name = "Aktivt")]
    Active,
    [Display(Name = "Avslutad")]
    Completed
}

public class Project
{
    public string Id { get; set; }

    [Required(ErrorMessage = "Du måste ange ett namn")]
    [MaxLength(100)]
    [Display(Name = "Namn")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Du måste ange en beskrivning")]
    [MaxLength(500)]
    [Display(Name = "Beskrivning")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Du måste ange en kund")]
    [Display(Name = "Kund")]
    public string CustomerId { get; set; }
    public Customer Customer { get; set; }

    [Display(Name = "Skapad")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Display(Name = "Status")]
    public ProjectStatus Status { get; set; } = ProjectStatus.Active;

    public ICollection<TimeEntry> TimeEntries { get; set; } = [];
}

public record AddProjectDto
{
    [Required(ErrorMessage = "Du måste ange ett namn")]
    [MaxLength(100)]
    [Display(Name = "Namn")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Du måste ange en beskrivning")]
    [MaxLength(500)]
    [Display(Name = "Beskrivning")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Du måste ange en kund")]
    [Display(Name = "Kund")]
    public string CustomerId { get; set; }
}
public record EditProjectDto
{
    [Required]
    public string Id { get; set; }

    [Required(ErrorMessage = "Du måste ange ett namn")]
    [MaxLength(100)]
    [Display(Name = "Namn")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Du måste ange en beskrivning")]
    [MaxLength(500)]
    [Display(Name = "Beskrivning")]
    public string Description { get; set; }

    [Display(Name = "Status")]
    public ProjectStatus Status { get; set; }

    [Required(ErrorMessage = "Du måste ange en kund")]
    [Display(Name = "Kund")]
    public string CustomerId { get; set; }
}