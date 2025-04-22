namespace C_;

public class MacBookObservable : IStocksObservable
{
    IList<IStocksObserver> observerList;
    int stockCount { get; set; }
    public MacBookObservable(int count){
        observerList = new List<IStocksObserver>();
        stockCount = count;
    }

    public void Add(IStocksObserver stockObserver)
    {
        observerList.Add(stockObserver);
    }

    public void AddStock(int newStockCount)
    {
        if(stockCount == 0){
            stockCount += newStockCount;
            Notify();
        } 
    }

    public void Notify()
    {
        foreach(IStocksObserver observer in observerList){
            observer.Update(this);
        }
    }

    public void Remove(IStocksObserver stockObserver)
    {
        observerList.Remove(stockObserver);
    }

    public int GetStockCount() => stockCount;
}
