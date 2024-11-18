namespace HotelManagement
{
    public abstract class Room
    {
        //private fields
        private string description = "Hotel room";

        //public properties
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //abstract methods
        public abstract double GetCost();
    }

    public abstract class RoomDecorator: Room
    {
        public abstract string GetDescription();
    }

    public enum RoomType
    {
        Standard,
        SeaView
        //GardenRoom
    }
}
