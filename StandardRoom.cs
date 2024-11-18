namespace HotelManagement
{
    public class StandardRoom : Room
    {
        public StandardRoom()
        {
            Description += ": Standard";
        }
        public override double GetCost()
        {
            return 75.00;
        }
    }
}
