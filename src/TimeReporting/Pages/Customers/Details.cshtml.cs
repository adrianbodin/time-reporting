using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting
{
    public class DetailsModel : PageModel
    {
        private readonly TimeReporting.Data.AppDbContext _context;

        public DetailsModel(TimeReporting.Data.AppDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FirstOrDefaultAsync(m => m.Id == id);

            if (customer is not null)
            {
                Customer = customer;

                return Page();
            }

            return NotFound();
        }
    }
}
