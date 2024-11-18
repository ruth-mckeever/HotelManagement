namespace HotelManagement
{
    public class BreakfastDecorator : RoomDecorator
    {
        Room room;

        public BreakfastDecorator(Room room)
        {
            this.room = room;
            Description = GetDescription();
        }
        public override double GetCost()
        {
            return room.GetCost() + 10.0;
        }

        public override string GetDescription()
        {
            return $"{room.Description}, breakfast included";
        }
    }
}
