namespace StatePattern;

public class VendingMachine
{
    double totalAmount = 0;
    IState currentState;
    Inventory _Inventory = new Inventory();
    Product? selectedProduct;

    public VendingMachine()
    {
        selectedProduct = null;
        currentState = new IdleState(this);
    }

    public void setState(IState state)
    {
        currentState = state;
    }
    public void Start()
    {
        currentState.Start();
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

    public bool isSufficientAmount()
    {
        return totalAmount >= selectedProduct?.price;
    }

    public void SelectProduct(int code)
    {
        currentState.SelectProduct(code);
    }

    public void AddCoin(Coin coin){
        totalAmount += (int)coin/100.0;
    }

    public void AddNote(Note note){
        totalAmount += (int)note/1.0;
    }

    public void processOrder(){
        _Inventory.RemoveProduct(selectedProduct.code, 1);
        totalAmount -= selectedProduct.price;
        ReturnChange();
    }
}
