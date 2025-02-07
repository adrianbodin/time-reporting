using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
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

        _db.Attach(WorkType).State = EntityState.Modified;

        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!WorkTypeExists(WorkType.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool WorkTypeExists(string id)
    {
        return _db.WorkTypes.Any(e => e.Id == id);
    }
}