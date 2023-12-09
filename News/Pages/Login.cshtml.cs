using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Models;

namespace News.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }
    }
}
