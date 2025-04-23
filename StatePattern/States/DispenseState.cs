namespace StatePattern;

public class DispenseState: IState
{
    private VendingMachine _vendingMachine;

    public DispenseState(VendingMachine vendingMachine)
    {            
        _vendingMachine = vendingMachine;   
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel order in dispensing state");
    }

    public void DispenseProduct()
    {
        Console.WriteLine("Dispensing Product");
        _vendingMachine.processOrder();
        _vendingMachine.setState(new IdleState(_vendingMachine));
    }

    public void InsertCoins(Coin coin)
    {
        Console.WriteLine("Payment already done");
    }

    public void InsertNotes(Note note)
    {
        Console.WriteLine("Payment already done");
    }

    public void SelectProduct(int code)
    {
        Console.WriteLine("Product already selected");
    }

    public void Start()
    {
        Console.WriteLine("Please wait for product to be dispensed to start a new order");
    }
}
