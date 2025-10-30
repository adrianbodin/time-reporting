using System.ComponentModel.DataAnnotations;
using EntreprenadPro.Data;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.WorkTypes;

public record AddWorkTypeDto
{
    [Required(ErrorMessage = "You must provide a name for the work type")]
    public string Name { get; init; } = null!;

    [Required]
    [Display(Name = "Hourly Rate")]
    public int HourlyRate { get; init; }
};

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public AddWorkTypeDto WorkType { get; set; } = null!;

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        try
        {
            bool doesWorkTypeExist = await _context.WorkTypes
                .AnyAsync(wt => wt.Name.ToLower() == WorkType.Name.ToLower());

            if (doesWorkTypeExist)
            {
                ModelState.AddModelError("WorkType.Name", "A work type with this name already exists.");
                Response.StatusCode = StatusCodes.Status409Conflict;
                return Page();
            }


            var newWorkType = new WorkType
            {
                Id = Guid.NewGuid().ToString(),
                Name = WorkType.Name,
                HourlyRate = WorkType.HourlyRate,
            };

            _context.WorkTypes.Add(newWorkType);
            await _context.SaveChangesAsync();

            TempData["Notification-Type"] = NotificationType.Success;
            TempData["Notification-Message"] = $"Work Type {newWorkType.Name} has been created";

            return RedirectToPage("./Index");
        }
        catch (Exception e)
        {
            TempData["Notification-Type"] = NotificationType.Danger;
            TempData["Notification-Message"] = "There was an error, please try again.";

            return RedirectToPage("./Index");
        }
    }
}
