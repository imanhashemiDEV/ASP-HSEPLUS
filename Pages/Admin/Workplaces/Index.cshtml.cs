using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.Workplace
{
    public class IndexModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public IndexModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Workplace> Workplace { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Workplace = await _context.Workplaces.ToListAsync();
        }
    }
}
