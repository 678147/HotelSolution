using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CustomerFunction;

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

            // TODO: Lagre brukeren i databasen

            Message = "Registrering vellykket! Du kan nå logge inn.";
        }
    }
}
