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
    public class IndexModel : PageModel
    {
        private readonly siemens.Data.AppDbContext _context;

        public IndexModel(siemens.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Machine> Machine { get;set; }

        public async Task OnGetAsync()
        {
            Machine = await _context.Machine.ToListAsync();
        }
    }
}
