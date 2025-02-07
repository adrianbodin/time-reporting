using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

public record AddEmployeeDto
{
    [Required]
    [Display(Name = "First Name")]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    public DateOnly HireDate { get; set; }
}

[Authorize(Roles = "Admin")]
public class CreateModel : PageModel
{
    private readonly UserManager<Employee> _userManager;

    public CreateModel(UserManager<Employee> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty(SupportsGet = true)]
    public AddEmployeeDto Employee { get; set; } = null!;

    public IActionResult OnGet()
    {
        Employee.HireDate = DateOnly.FromDateTime(DateTime.Now);
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var user = Activator.CreateInstance<Employee>();

        try
        {
            user.FullName = Employee.FullName;
            user.Email = Employee.Email;
            user.PhoneNumber = Employee.PhoneNumber;
            user.HireDate = Employee.HireDate;
            user.UserName = Employee.Email;
            user.EmailConfirmed = true;

            var result = await _userManager.CreateAsync(user, Employee.Password);

            if (!result.Succeeded)
            {
                TempData["Notification-Type"] = NotificationType.Danger;
                TempData["Notification-Message"] = "Failed to create user.";

                return Page();
            }


            TempData["Notification-Type"] = NotificationType.Success;
            TempData["Notification-Message"] = $"Employee {user.FullName} created successfully.";
        }
        catch (Exception e)
        {
            TempData["Notification-Type"] = NotificationType.Danger;
            TempData["Notification-Message"] = "Failed to create user.";
        }

        return RedirectToPage("/Employees/Index");
    }
}