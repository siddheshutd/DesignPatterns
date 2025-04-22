namespace C_;

public class VendingMachine
{
    int totalAmount = 0;
    IState currentState;
    Inventory _Inventory = new Inventory();
    Product? selectedProduct;

    public VendingMachine(IState state)
    {
        selectedProduct = null;
        currentState = state;
    }

    public void setState(IState state)
    {
        currentState = state;
    }
    public void Cancel()
    {
        currentState.Cancel();
    }

    public void DispenseProduct()
    {
        currentState.DispenseProduct();
    }

    public void InsertCoins(Coin coins)
    {
        currentState.InsertCoins(coins);
    }

    public void AddProduct(Product product, int totalAmount)
    {
        _Inventory.AddProduct(product, totalAmount);
    }

    public void Reset(){
        ReturnChange();
        selectedProduct = null;
    }

    public void ReturnChange()
    {
        if (totalAmount > 0)
        {
            Console.WriteLine("Returning change: " + totalAmount);
            totalAmount = 0;
        }
    }

    public bool isProductAvailable(int code)
    {
        return _Inventory.isAvailable(code);
    }

    public void SetSelectedProduct(int code)
    {
        selectedProduct = _Inventory.GetProduct(code);
    }

    public bool isSufficientAmount(int code)
    {
        //return _Inventory.isSufficientAmount(code, totalAmount);
    }

    public void SelectProduct(int code)
    {
        currentState.SelectProduct(code);
    }

    public void AddCoin(Coin coin){
        totalAmount += (int)coin/100;
    }

    public void AddNote(Note note){
        totalAmount += (int)note;
    }
}
