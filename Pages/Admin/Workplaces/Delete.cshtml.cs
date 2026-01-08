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
    public class DeleteModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public DeleteModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Workplace Workplace { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplaces.FirstOrDefaultAsync(m => m.id == id);

            if (workplace is not null)
            {
                Workplace = workplace;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplaces.FindAsync(id);
            if (workplace != null)
            {
                Workplace = workplace;
                _context.Workplaces.Remove(Workplace);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
