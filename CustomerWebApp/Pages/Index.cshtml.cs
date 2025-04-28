using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerWebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }  // <<== ADD THIS
        [BindProperty]
        public string Password { get; set; }  // <<== AND THIS

        public string Message { get; set; }

        private static readonly List<(string Username, string Password)> Users = new()
        {
            ("admin", "admin123"),
            ("user", "user123")
        };

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var user = Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user == default)
            {
                Message = "Invalid username or password.";
                return Page();
            }
            HttpContext.Session.SetString("Username", Username);
            return RedirectToPage("/sok");
        }
    }
}
