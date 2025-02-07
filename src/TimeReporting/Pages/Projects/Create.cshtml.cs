using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

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

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnGet()
    {
        Customers = await _context.Customers.ToListAsync();
        return Page();
    }

    public List<Customer> Customers { get; set; } = null!;

    [BindProperty]
    public AddProjectDto Project { get; set; } = null!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var project = new Project
        {
            Id = Guid.NewGuid().ToString(),
            Name = Project.Name,
            Description = Project.Description,
            CustomerId = Project.CustomerId
        };

        try
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            TempData["Notification-Message"] = $"Project \"{project.Name}\" created successfully.";
            TempData["Notification-Type"] = NotificationType.Success;
        }
        catch (Exception e)
        {
            TempData["Notification-Message"] = $"An error occurred while creating the project: {e.Message}";
            TempData["Notification-Type"] = NotificationType.Danger;
        }

        return RedirectToPage("./Index");
    }
}