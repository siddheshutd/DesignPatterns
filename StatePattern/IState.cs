namespace StatePattern;

public interface IState
{
    public void Start();
    public void InsertCoins(Coin coin);
    public void InsertNotes(Note note);
    public void SelectProduct(int code);
    public void DispenseProduct();
    public void Cancel();
}
