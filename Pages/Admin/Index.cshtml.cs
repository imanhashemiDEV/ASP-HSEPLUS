using HSEPLUS.Data;
using HSEPLUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HSEPLUS.Pages.Admin
{
    public class IndexModel : PageModel
    {

        public readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int User_Count { get; set; } = 0;

        public void OnGet()
        {
            User_Count = _context.Users.Count();
        }
    }
}
