using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

public class CreateModel(IAppDbContext context) : PageModel
{
    public List<Customer> Customers { get; set; } = null!;

    [BindProperty]
    public AddProjectDto Project { get; set; } = null!;

    public async Task<IActionResult> OnGet()
    {
        Customers = await context.Customers
            .AsNoTracking()
            .ToListAsync();

        return Page();
    }

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
            context.Projects.Add(project);
            await context.SaveChangesAsync();

            this.SendNotification(NotificationType.Success, $"The project \"{project.Name}\" was created successfully");
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
        }

        return RedirectToPage("./Index");
    }
}