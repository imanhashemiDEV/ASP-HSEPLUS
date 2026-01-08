using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.User_infos
{
    public class EditModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public EditModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User_info User_info { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_info =  await _context.User_infos.FirstOrDefaultAsync(m => m.id == id);
            if (user_info == null)
            {
                return NotFound();
            }
            User_info = user_info;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(User_info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_infoExists(User_info.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool User_infoExists(long id)
        {
            return _context.User_infos.Any(e => e.id == id);
        }
    }
}
