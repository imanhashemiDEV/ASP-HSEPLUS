using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HSEPLUS.Data;
using HSEPLUS.Models;

namespace HSEPLUS.Pages.Admin.User_infos
{
    public class DetailsModel : PageModel
    {
        private readonly HSEPLUS.Data.ApplicationDbContext _context;

        public DetailsModel(HSEPLUS.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User_info User_info { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? user_id)
        {

            if (user_id == null)
            {
                return NotFound();
            }


            var user_info = await _context.User_infos.FirstOrDefaultAsync(m => m.user_id == 1);

            if (user_info is not null)
            {
                User_info = user_info;

                return Page();
            }

            return NotFound();
        }
    }
}
