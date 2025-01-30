using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.WorkTypes
{
    public class DetailsModel : PageModel
    {
        private readonly TimeReporting.Data.AppDbContext _context;

        public DetailsModel(TimeReporting.Data.AppDbContext context)
        {
            _context = context;
        }

        public WorkType WorkType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worktype = await _context.WorkTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (worktype is not null)
            {
                WorkType = worktype;

                return Page();
            }

            return NotFound();
        }
    }
}
