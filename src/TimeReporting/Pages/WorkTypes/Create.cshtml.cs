using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.WorkTypes
{
    public class CreateModel : PageModel
    {
        private readonly TimeReporting.Data.AppDbContext _context;

        public CreateModel(TimeReporting.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WorkType WorkType { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WorkTypes.Add(WorkType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
