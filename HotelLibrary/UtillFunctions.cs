using HotelLibrary.DBContex;
using HotelLibrary.Models;
using System;

namespace HotelLibrary
{
    public class UtillFunctions
    {
        public void registerBooking(string email, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            using (var context = new AppDbContext())
            {
                DateTime newCheckIn = checkInDate;
                DateTime newCheckOut = checkOutDate;

                bool isAvailable = context.Bookings.Any(b =>
                     b.RoomNumber == roomNumber &&
                     (
                         (newCheckIn.CompareTo(b.CheckInDate) >= 0 && newCheckIn.CompareTo(b.CheckOutDate) < 0) ||
                         (newCheckOut.CompareTo(b.CheckInDate) > 0 && newCheckOut.CompareTo(b.CheckOutDate) <= 0) ||
                         (newCheckIn.CompareTo(b.CheckInDate) <= 0 && newCheckOut.CompareTo(b.CheckOutDate) >= 0)
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
        public RoomType GetRoomTypeFromInt(int i)
        {
            switch (i)
            {
                case 1:
                    return RoomType.Single;
                case 2:
                    return RoomType.Double;
                case 3:
                    return RoomType.Suite;
                default:
                    throw new ArgumentOutOfRangeException("Invalid room type");
            }
        }
        public int GetRoomTypeFromEnum(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return 1;
                case RoomType.Double:
                    return 2;
                case RoomType.Suite:
                    return 3;
                default:
                    throw new ArgumentOutOfRangeException("Invalid room type");
            }
        }
        public TaskStatus GetTaskStatusFromInt(int i)
        {
            switch (i)
            {
                case 1:
                    return TaskStatus.New;
                case 2:
                    return TaskStatus.Inprogress;
                case 3:
                    return TaskStatus.Finished;
                default:
                    throw new ArgumentOutOfRangeException("Invalid task status");
            }
        }
        public int GetTaskStatusFromEnum(TaskStatus taskStatus)
        {
            switch (taskStatus)
            {
                case TaskStatus.New:
                    return 1;
                case TaskStatus.Inprogress:
                    return 2;
                case TaskStatus.Finished:
                    return 3;
                default:
                    throw new ArgumentOutOfRangeException("Invalid task status");
            }
        }
        public MaintenanceType GetMaintenanceTypeFromInt(int i)
        {
            switch (i)
            {
                case 1:
                    return MaintenanceType.Cleaning;
                case 2:
                    return MaintenanceType.Maintenace;
                case 3:
                    return MaintenanceType.Service;
                default:
                    throw new ArgumentOutOfRangeException("Invalid maintenance type");
            }
        }
        public int GetMaintenanceTypeFromEnum(MaintenanceType maintenanceType)
        {
            switch (maintenanceType)
            {
                case MaintenanceType.Cleaning:
                    return 1;
                case MaintenanceType.Maintenace:
                    return 2;
                case MaintenanceType.Service:
                    return 3;
                default:
                    throw new ArgumentOutOfRangeException("Invalid maintenance type");
            }
        }

        public int GetTaskStatusFromString(string status) 
        {
            if (status.ToLower() == "new") return 1;
            else if (status.ToLower() == "inprogress") return 2;
            else if (status.ToLower() == "finished") return 3;
            else throw new ArgumentOutOfRangeException("Invalid maintenance status");
        }
        public int GetTaskTypeFromString(string type)
        {
            if (type.ToLower() == "cleaning") return 1;
            else if (type.ToLower() == "maintenance") return 2;
            else if (type.ToLower() == "service") return 3;
            else throw new ArgumentOutOfRangeException("Invalid maintenance type");
        }
    }
}
