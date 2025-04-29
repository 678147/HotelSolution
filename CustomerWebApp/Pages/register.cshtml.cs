using HotelLibrary.DBContex;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

        private readonly AppDbContext _context;
        public RegisterModel(AppDbContext context)
        {
            _context = context; 
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Password != ConfirmPassword)
            {
                Message = "Passordene stemmer ikke overens.";
                return;
            }

            new CustomerFunction().RegisterCustomer(Email, Username, Password, _context);

            Message = "Registrering vellykket! Du kan nå logge inn.";
        }
    }
}
