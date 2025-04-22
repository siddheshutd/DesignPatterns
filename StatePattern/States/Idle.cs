namespace C_;

public class Idle : IState
{
    private VendingMachine _vendingMachine;

    public Idle(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }
    public void CancelTransaction()
    {
        throw new NotImplementedException("Cannot cancel transaction in idle state");
    }

    public void DispenseProduct()
    {
        throw new NotImplementedException("Cannot dispense product in idle state");
    }

    public void EnterCoins(int coins)
    {
        _vendingMachine.setState(new CoinInsertion(_vendingMachine));
        Console.WriteLine($"{coins} coins inserted");
    }

    public void ReturnCoins()
    {
        throw new NotImplementedException("Cannot return coins in idle state");
    }

    public void SelectProduct(int code)
    {
        throw new NotImplementedException("Cannot select product in idle state");
    }
}
