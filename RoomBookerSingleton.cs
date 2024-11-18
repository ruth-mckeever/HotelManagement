namespace HotelManagement
{
    public class RoomBookerSingleton
    {
        //Only one instance - we need a single point of control of the number of hotel rooms being booked
        public static readonly RoomBookerSingleton Instance = new RoomBookerSingleton();

        //Fields to store number of available rooms
        public static int accessibleRoomsSeaView = 3;
        public static int accessibleRoomsStandard = 5;
        public static int standardRoom = 10;
        public static int seaViewRoom = 4;

        //Constructor is private - don't allow new instances of this to be created - that is the point of the singleton
        private RoomBookerSingleton() { }

        public bool BookRoom(RoomType type, bool isAccessible)
        {
            bool successfulBooking = false;     //This isn't strictly necessary - we could just return true whenever we book a room and return false at the end.
            switch (type)
            {
                case RoomType.Standard:
                    if (isAccessible && accessibleRoomsStandard > 0)
                    {
                        accessibleRoomsStandard--;  //Reducing the number of available rooms by 1
                        successfulBooking = true;
                    }
                    else if(!isAccessible && standardRoom > 0)
                    {
                        standardRoom--;
                        successfulBooking = true;
                    }
                    break;
                case RoomType.SeaView:
                    {
                        if(isAccessible && accessibleRoomsSeaView > 0)
                        {
                            accessibleRoomsSeaView--;
                            successfulBooking = true;
                        }
                        else if(!isAccessible && seaViewRoom > 0)
                        {
                            seaViewRoom--;
                            successfulBooking = true;
                        }
                        break;
                    }
            }
            return successfulBooking;
        }
    }
}
