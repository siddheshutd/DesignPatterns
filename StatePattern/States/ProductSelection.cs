namespace C_;

public class ProductSelection : IState
{
    private VendingMachine _vendingMachine;

    public ProductSelection(VendingMachine vendingMachine)
    {            
        _vendingMachine = vendingMachine;   
    }
    public void CancelTransaction()
    {
        Console.WriteLine("Transaction cancelled");
        _vendingMachine.ReturnCoins();
        _vendingMachine.setState(new Idle(_vendingMachine));
    }

    public void DispenseProduct()
    {
        throw new NotImplementedException();
    }

    public void EnterCoins(int coins)
    {
        Console.WriteLine("Coins already entered");
    }

    public void ReturnCoins()
    {
        throw new NotImplementedException();
    }

    public void SelectProduct(int code)
    {
        Console.WriteLine("Product selection already in progress");
    }
}
