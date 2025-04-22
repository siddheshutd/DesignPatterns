namespace C_;

public class VendingMachine : IState
{
    int coins = 0;
    IState currentState;

    public VendingMachine(IState state)
    {
        currentState = state;
    }
    public void setState(IState state)
    {
        currentState = state;
    }
    public void CancelTransaction()
    {
        currentState.CancelTransaction();
    }

    public void DispenseProduct()
    {
        currentState.DispenseProduct();
    }

    public void EnterCoins(int coins)
    {
        currentState.EnterCoins(coins);
    }

    public void ReturnCoins()
    {
        Console.WriteLine($"{coins} Coins returned");
        coins = 0;
    }

    public void SelectProduct(int code)
    {
        currentState.SelectProduct(code);
    }
}
