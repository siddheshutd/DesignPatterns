namespace StatePattern;

public class ProductSelection : IState
{
    private VendingMachine _vendingMachine;

    public ProductSelection(VendingMachine vendingMachine)
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
        Console.WriteLine("Select Product First");
    }

    public void InsertCoins(Coin coin)
    {
        Console.WriteLine("Select Product before Inserting Coins");
    }

    public void InsertNotes(Note note)
    {
        Console.WriteLine("Select Product before Inserting Notes");
    }

    public void SelectProduct(int code)
    {
        if(_vendingMachine.isProductAvailable(code)){
            _vendingMachine.SetSelectedProduct(code);
            _vendingMachine.setState(new TransactionState(_vendingMachine));
            Console.WriteLine("Product Selected");
        } else {
            Console.WriteLine("Product Not Available");
        }
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
}
