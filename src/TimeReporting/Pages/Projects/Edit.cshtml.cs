using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;
using static TimeReporting.Models.NotificationType;

namespace TimeReporting.Pages.Projects;

[Authorize]
public class EditModel(IAppDbContext db) : PageModel
{
    [BindProperty]
    public EditProjectDto Project { get; set; }

    public IList<Customer> Customers { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
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
            this.SendNotification(Danger, "Project not found.");
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
            this.SendNotification(Danger, "Project not found.");
            return NotFound();
        }

        project.Name = Project.Name;
        project.Description = Project.Description;
        project.CustomerId = Project.CustomerId;
        await db.SaveChangesAsync();

        this.SendNotification(Success, "The project was updated successfully");
        return RedirectToPage("./Index");
    }
}