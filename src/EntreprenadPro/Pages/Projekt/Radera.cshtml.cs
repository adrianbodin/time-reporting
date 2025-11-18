using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Projekt;

public class RaderaModel(IAppDbContext context) : PageModel
{
    [BindProperty] public Project Project { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        this.SetTitle("Delete Project");

        if (id == null) return NotFound();

        try
        {
            var project = await context.Projects.FirstOrDefaultAsync(m => m.Id == id);

            if (project is null)
            {
                this.SendNotification(NotificationType.Danger, "Project not found.");
                return NotFound();
            }

            Project = project;
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? id)
    {
        if (id == null) return NotFound();

        try
        {
            var project = await context.Projects.FindAsync(id);

            if (project is null)
            {
                this.SendNotification(NotificationType.Danger, "Project not found.");
                return NotFound();
            }

            context.Projects.Remove(project);
            await context.SaveChangesAsync();

            this.SendNotification(NotificationType.Success,
                $"The project \"{project.Name}\" was removed successfully.");
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return NotFound();
        }

        return RedirectToPage("./Index");
    }
}