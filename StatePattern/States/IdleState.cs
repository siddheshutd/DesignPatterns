namespace C_;

public class IdleState : IState
{
    private VendingMachine _vendingMachine;

    public IdleState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel process in idle state");
    }

    public void DispenseProduct()
    {
        Console.WriteLine("Select product first");
    }

    public void InsertCoins(Coin coin)
    {
        Console.WriteLine("Select product first");
    }

    public void InsertNotes(Note note)
    {
        Console.WriteLine("Select product first");
    }

    public void SelectProduct(int code)
    {
        Console.WriteLine("Start the process to select product");
    }

    public void Start()
    {
        Console.WriteLine("Starting the process");
        _vendingMachine.setState(new ProductSelection(_vendingMachine));
    }
}
