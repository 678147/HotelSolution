using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System;
using HotelLibrary;

public class BookingPageModel : PageModel
{
    [BindProperty]
    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [BindProperty]
    [DataType(DataType.Date)]
    [Required]
    public DateTime StartDate { get; set; }

    [BindProperty]
    [DataType(DataType.Date)]
    [Required]
    public DateTime EndDate { get; set; }

    [BindProperty]
    [Required]
    public int RoomNumber { get; set; }

    private readonly UtillFunctions _utillFunctions;

    public BookingPageModel()
    {
        _utillFunctions = new UtillFunctions();
    }

    public void OnGet()
    {
        RoomNumber = HttpContext.Session.GetInt32("RoomNumber") ?? 0;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            _utillFunctions.registerBooking(Email, RoomNumber, StartDate, EndDate);

            return RedirectToPage("/status");
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return Page();
        }
    }
}
