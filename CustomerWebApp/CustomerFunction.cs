using HotelLibrary.DBContex;
using HotelLibrary.Models;

namespace CustomerWebApp
{
    public class CustomerFunction
    {
        public void registerCustomer(string email, string name, string password) {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.Email == email))
                {
                    throw new InvalidOperationException("A user with this email already exists.");
                }

                // Create a new user
                var newUser = new User
                {
                    Email = email,
                    Name = name,
                    Password = password // Consider hashing the password for security
                };

                // Add the user to the database
                context.Users.Add(newUser);
                context.SaveChanges();
            }

        }

        public void registerBooking(string email, int roomNumber, string checkInDate, string checkOutDate)
        {
            using (var context = new AppDbContext())
            {
                DateTime newCheckIn = DateTime.Parse(checkInDate);
                DateTime newCheckOut = DateTime.Parse(checkOutDate);
                bool isAvailable = context.Bookings.Any(b =>
                     b.RoomNumber == roomNumber &&
                     (
                         (newCheckIn >= DateTime.Parse(b.CheckInDate) && newCheckIn < DateTime.Parse(b.CheckOutDate)) || // New check-in is within an existing booking
                         (newCheckOut > DateTime.Parse(b.CheckInDate) && newCheckOut <= DateTime.Parse(b.CheckOutDate)) || // New check-out is within an existing booking
                         (newCheckIn <= DateTime.Parse(b.CheckInDate) && newCheckOut >= DateTime.Parse(b.CheckOutDate))   // New booking fully overlaps an existing booking
                     )
                 );
                if (isAvailable)
                {
                    throw new InvalidOperationException("The room is already booked for the selected time period.");
                }
            
                var newBooking = new Booking
                {
                    Email = email,
                    RoomNumber = roomNumber,
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    CheckedIn = false
                };

                context.Bookings.Add(newBooking);
                context.SaveChanges();
            }
        }

    }
}
