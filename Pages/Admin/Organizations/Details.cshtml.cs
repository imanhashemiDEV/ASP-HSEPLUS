using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.Organization
{
    public class DetailsModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public DetailsModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Organization Organization { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations.FirstOrDefaultAsync(m => m.id == id);

            if (organization is not null)
            {
                Organization = organization;

                return Page();
            }

            return NotFound();
        }
    }
}
