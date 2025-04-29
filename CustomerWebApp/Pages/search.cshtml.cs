using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelLibrary.DBContex;
using HotelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelLibrary;

namespace CustomerWebApp.Pages
{
    public class searchModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly UtillFunctions _utillFunctions;

        public searchModel(AppDbContext context, UtillFunctions utillFunctions)
        {
            _context = context;
            _utillFunctions = utillFunctions;
        }

        [BindProperty]
        public int RoomSize { get; set; }

        [BindProperty]
        public string RoomType { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        public List<RoomAvailability> SearchResults { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            int roomTypeInt = 1;
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

            var rooms = _context.Rooms
                .Where(r => r.RoomSize >= RoomSize && r.RoomType == roomTypeInt)
                .ToList();
    
            SearchResults = rooms.Select(room =>
            {
                var nextBooking = _context.Bookings
                    .Where(b => b.RoomNumber == room.RoomNumber && b.CheckInDate > DateTime.Now)
                    .OrderBy(b => b.CheckInDate)
                    .FirstOrDefault();

                return new RoomAvailability
                {
                    Room = room,
                    AvailableUntil = nextBooking != null ? nextBooking.CheckInDate : (DateTime?)null
                };
            }).ToList();
        }

        public string GetRoomType(int roomType)
        {
            var roomTypeName = _utillFunctions.GetRoomTypeFromInt(roomType);
            return roomTypeName.ToString();
        }
    }

    public class RoomAvailability
    {
        public Room Room { get; set; }
        public DateTime? AvailableUntil { get; set; }
    }
}
