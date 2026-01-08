using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.User_infos
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
        public User_info User_info { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User_infos.Add(User_info);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
