using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.Scaffolding.Shared.T4Templating;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.WorkTypes;

public class EditModel : PageModel
{
    private readonly AppDbContext _db;

    public EditModel(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public WorkType WorkType { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var worktype =  await _db.WorkTypes.FirstOrDefaultAsync(m => m.Id == id);
        if (worktype == null)
        {
            return NotFound();
        }
        WorkType = worktype;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var workType = await _db.WorkTypes.FindAsync(WorkType.Id);

        if (workType is null)
        {
            this.SendNotification(NotificationType.Danger, "Work type not found.");
            return NotFound();
        }

        workType.Name = WorkType.Name;
        workType.HourlyRate = WorkType.HourlyRate;

        await _db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success, $"The work type \"{workType.Name}\" was updated successfully.");

        return RedirectToPage("./Index");
    }

}