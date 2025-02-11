using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

public record EditProjectDto
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public string CustomerId { get; set; }
}

[Authorize]
public class EditModel(IAppDbContext db) : PageModel
{
    [BindProperty]
    public EditProjectDto Project { get; set; }

    public IList<Customer> Customers { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        this.SetTitle("Edit Project");

        var project = await db.Projects
            .Where(p => p.Id == id)
            .Select(p => new EditProjectDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                CustomerId = p.CustomerId
            })
            .FirstOrDefaultAsync();

        if (project is null)
        {
            this.SendNotification(NotificationType.Danger, "Project not found.");
            return RedirectToPage("./Index");
        }

        Project = project;
        Customers = await db.Customers.AsNoTracking().ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            Customers = await db.Customers.AsNoTracking().ToListAsync();
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var project = await db.Projects.FindAsync(Project.Id);

        if (project is null)
        {
            this.SendNotification(NotificationType.Danger, "Project not found.");
            return NotFound();
        }

        project.Name = Project.Name;
        project.Description = Project.Description;
        project.CustomerId = Project.CustomerId;
        await db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success, "The project was updated successfully");

        return RedirectToPage("./Index");
    }
}