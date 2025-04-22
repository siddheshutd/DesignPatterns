namespace C_;

public class CoinInsertion : IState
{
    VendingMachine _vendingMachine;
    public CoinInsertion(VendingMachine machine)
    {
        _vendingMachine = machine;
    }
    public void CancelTransaction()
    {
        Console.WriteLine("Transaction cancelled");
        _vendingMachine.ReturnCoins();
        _vendingMachine.setState(new Idle(_vendingMachine));
    }

    public void DispenseProduct()
    {
        Console.WriteLine("Cannot dispense product without selecting product");
    }

    public void EnterCoins(int amount)
    {
        Console.WriteLine("Coins insertion already active");
    }

    public void ReturnCoins()
    {
        _vendingMachine.ReturnCoins();
        _vendingMachine.setState(new Idle(_vendingMachine));
    }

    public void SelectProduct(int code)
    {
        _vendingMachine.setState(new ProductSelection(_vendingMachine));
        _vendingMachine.SelectProduct(code);
    }
}
