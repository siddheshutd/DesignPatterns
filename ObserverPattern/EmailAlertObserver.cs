namespace ObserverPattern;

public class EmailAlertObserver : IStocksObserver
{
    private string _email;
    public EmailAlertObserver(string email){
        _email = email;
    }
    public void Update(IStocksObservable observable)
    {
        Console.WriteLine($"Hello {_email}, new stock added for Macbook! Count added: {observable.GetStockCount()}");
    }
}