using HSEPLUS.Data;
using HSEPLUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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

        public async Task OnGetAsync()
        {
            Users = await _context.Users.OrderByDescending(c=>c.id).Take(10).ToListAsync();
        }
    }
}
