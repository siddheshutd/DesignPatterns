namespace StatePattern;

public class TransactionState : IState
{
    private VendingMachine _vendingMachine;

    public TransactionState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void Cancel()
    {
        Console.WriteLine("Product Selection Cancelled");
        _vendingMachine.Reset();
        _vendingMachine.setState(new IdleState(_vendingMachine));
    }

    public void DispenseProduct()
    {
        if(_vendingMachine.isSufficientAmount()){
            _vendingMachine.setState(new DispenseState(_vendingMachine));
            _vendingMachine.DispenseProduct();
        } else {
            Console.WriteLine("Insufficient amount");
        }
    }

    public void InsertCoins(Coin coin)
    {
        _vendingMachine.AddCoin(coin);
    }

    public void InsertNotes(Note note)
    {
        _vendingMachine.AddNote(note);
    }

    public void SelectProduct(int code)
    {
        Console.WriteLine("Product already selected. Please make payment");
    }

    public void Start()
    {
        Console.WriteLine("Machine is already in transaction state");
    }
}
