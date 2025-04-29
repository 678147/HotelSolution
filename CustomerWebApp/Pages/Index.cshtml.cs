using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerWebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }  
        [BindProperty]
        public string Password { get; set; } 

        public string Message { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (new CustomerFunction().LoginCustomer(Username, Password))
            {
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("/search");
            }
            else
            {
                Message = "Invalid username or password.";
                return Page();
            }
        }
    }
}
