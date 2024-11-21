namespace HotelManagement
{
    public interface IObserver
    {
        void Update(int availableRooms);
    }

    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
