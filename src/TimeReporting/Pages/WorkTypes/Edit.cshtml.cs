using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.WorkTypes
{
    public class EditModel : PageModel
    {
        private readonly TimeReporting.Data.AppDbContext _context;

        public EditModel(TimeReporting.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WorkType WorkType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worktype =  await _context.WorkTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (worktype == null)
            {
                return NotFound();
            }
            WorkType = worktype;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WorkType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
            return _context.WorkTypes.Any(e => e.Id == id);
        }
    }
}
