namespace HotelManagement
{
    public class ChampagneDecorator: RoomDecorator
    {
        Room room;

        public ChampagneDecorator(Room room)
        {
            this.room = room;
            Description = GetDescription();
        }

        public override double GetCost()
        {
            return room.GetCost() + 60.0;
        }

        public override string GetDescription()
        {
            return $"{room.Description}, champagne included";
        }
    }
}
