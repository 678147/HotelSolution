using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelLibrary.DBContex; // your DbContext
using HotelLibrary.Models; // your Room model
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerWebApp.Pages
{
    public class sokModel : PageModel
    {
        private readonly AppDbContext _context;

        public sokModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int RoomSize { get; set; }

        [BindProperty]
        public string RoomType { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        public List<Room> SearchResults { get; set; }

        public void OnGet()
        {
            // nothing initially
        }

        public void OnPost()
        {
            int roomTypeInt = -1;

            if (RoomType == "Single")
            {
                roomTypeInt = 1;
            }
            else if (RoomType == "Double")
            {
                roomTypeInt = 2;
            }
            else if (RoomType == "Suite")
            {
                roomTypeInt = 3;
            }
            SearchResults = _context.Rooms
                .Where(r => r.RoomSize >= RoomSize
                            && r.RoomType == roomTypeInt  
                           /* Here you would also check if room is available for the date range */
                           )
                .ToList();
        }
    }
}
