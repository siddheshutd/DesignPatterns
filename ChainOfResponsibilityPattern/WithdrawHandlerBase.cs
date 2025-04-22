namespace ChainOfResponsibilityPattern
{
    public abstract class WithdrawHandlerBase : IWithdrawHandler
    {
        protected IWithdrawHandler? _nextHandler;

        public void SetNextHandler(IWithdrawHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Dispense(int amount);
    }
}
