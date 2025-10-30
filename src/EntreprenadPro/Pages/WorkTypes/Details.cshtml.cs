using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntreprenadPro.Data;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.WorkTypes
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
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
