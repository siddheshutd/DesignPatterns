namespace C_;

public interface IStocksObserver
{
    void Update(IStocksObservable observable);
}