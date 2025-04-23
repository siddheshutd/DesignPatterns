namespace ObserverPattern;

public interface IStocksObserver
{
    void Update(IStocksObservable observable);
}