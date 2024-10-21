namespace _07_ObserverPattern._02Try
{
    internal interface IObservable
    {
        List<int> Items { get; }
        void AddNewObserver(Ibserver ibserver);
    }

}
