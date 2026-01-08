using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.Occupation
{
    public class IndexModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public IndexModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Occupation> Occupation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Occupation = await _context.Occupations.ToListAsync();
        }
    }
}
