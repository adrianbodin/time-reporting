using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Projekt;

public class SkapaModel : PageModel
{
    private readonly IAppDbContext _context;

    public SkapaModel(IAppDbContext context)
    {
        _context = context;
        Customers = new List<Customer>();
        Project = new AddProjectDto();
    }

    public List<Customer> Customers { get; set; }

    [BindProperty] public AddProjectDto Project { get; set; }

    public async Task<IActionResult> OnGet()
    {
        Customers = await _context.Customers
            .AsNoTracking()
            .ToListAsync();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Customers = await _context.Customers
            .AsNoTracking()
            .ToListAsync();

        if (!ModelState.IsValid) return Page();

        var project = new Project
        {
            Id = Project.Id,
            Name = Project.Name,
            Description = Project.Description,
            CustomerId = Project.CustomerId
        };

        try
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            this.SendNotification(NotificationType.Success, $"Projektet \"{project.Name}\" skapades");
            return RedirectToPage("/Projekt/Index");
        }
        catch (Exception)
        {
            this.SendNotification(NotificationType.Danger, "Det blev något fel");

            return Page();
        }
    }
}