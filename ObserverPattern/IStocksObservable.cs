namespace C_;

public interface IStocksObservable
{
    void Add(IStocksObserver stockObserver);
    void Remove(IStocksObserver stockObserver);
    void Notify();
    void AddStock(int newStockCount);
    int GetStockCount();
}
