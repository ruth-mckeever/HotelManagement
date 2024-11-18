namespace HotelManagement
{
    public class SeaViewRoom: Room
    {
        public SeaViewRoom()
        {
            Description += ": Sea View";
        }
        public override double GetCost()
        {
            return 100.00;
        }
    }
}
