using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using HotelLibrary.Models;
using HotelLibrary.DBContex;
using Microsoft.EntityFrameworkCore;

public class StatusModel : PageModel
{
    private readonly AppDbContext _context;

    public StatusModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public string Email { get; set; }

    public List<Booking> Bookings { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(Email))
        {
            Bookings = _context.Bookings
                .Where(b => b.Email == Email)
                .ToList();
        }
        else
        {
            Bookings = new List<Booking>();
        }
    }
}
