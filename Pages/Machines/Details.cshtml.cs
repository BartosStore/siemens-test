using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siemens.Data;
using siemens.Models;

namespace siemens.Pages.Machines
{
    public class DetailsModel : PageModel
    {
        private readonly siemens.Data.AppDbContext _context;

        public DetailsModel(siemens.Data.AppDbContext context)
        {
            _context = context;
        }

        public Machine Machine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Machine = await _context.Machine.FirstOrDefaultAsync(m => m.Id == id);

            if (Machine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
