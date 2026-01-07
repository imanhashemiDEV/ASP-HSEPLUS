using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HSEPLUS.Pages
{
    public class IndexModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("./Admin/Index");
        }
    }
}
