namespace HotelLibrary
{
    public class UtillFunctions
    {
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
    }
}
