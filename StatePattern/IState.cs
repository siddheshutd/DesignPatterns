namespace C_;

public interface IState
{
    public void EnterCoins(int coins);
    public void SelectProduct(int code);
    public void DispenseProduct();
    public void ReturnCoins();
    public void CancelTransaction();
}
