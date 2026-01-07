using HSEPLUS.Data;
using HSEPLUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HSEPLUS.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        public async Task OnGet()
        {
            Users = await _context.Users.OrderByDescending(c=>c.updated_at).Take(10).ToListAsync();
        }
    }
}
