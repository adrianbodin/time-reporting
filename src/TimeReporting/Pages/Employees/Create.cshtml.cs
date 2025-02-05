using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeReporting.Pages.Employees;

public record AddEmployeeDto
{
    [Required]
    [Display(Name = "First Name")]
    public string FullName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password {get; set;}

    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
    public string ConfirmPassword {get; set;}

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber {get; set;}

    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    public DateTime HireDate {get; set;}
}

[Authorize(Roles = "Admin")]
public class CreateModel : PageModel
{

    [BindProperty(SupportsGet = true)]
    public AddEmployeeDto Employee { get; set; } = null!;

    public IActionResult OnGet()
    {
        Employee.HireDate = DateTime.Now;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("./Index");
    }
}