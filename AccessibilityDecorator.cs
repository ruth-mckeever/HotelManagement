namespace HotelManagement
{
    public class AccessibilityDecorator : RoomDecorator
    {
        Room room;

        public AccessibilityDecorator(Room room)
        {
            this.room = room;
            Description = GetDescription();
        }
        public override double GetCost()
        {
            return room.GetCost();
        }

        public override string GetDescription()
        {
            return $"{room.Description}, wheelchair accessible";
        }
    }
}
