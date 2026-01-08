using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.Occupation
{
    public class CreateModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public CreateModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Occupation Occupation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Occupations.Add(Occupation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
