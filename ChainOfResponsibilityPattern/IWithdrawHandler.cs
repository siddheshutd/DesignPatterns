namespace ChainOfResponsibilityPattern
{
    public interface IWithdrawHandler
    {
        void SetNextHandler(IWithdrawHandler nextHandler);
        void Dispense(int amount);
    }
}
