namespace ChainOfResponsibilityPattern
{
    public class FiftyPoundHandler : WithdrawHandlerBase
    {
        public override void Dispense(int amount)
        {
            if (amount >= 50)
            {
                int numNotes = amount / 50;
                int remainder = amount % 50;
                Console.WriteLine($"Dispensing {numNotes} x £50 note(s)");

                if (remainder > 0 && _nextHandler != null)
                {
                    _nextHandler.Dispense(remainder);
                }
                else if (remainder > 0)
                {
                    Console.WriteLine($"Cannot dispense remaining £{remainder} with available denominations.");
                }
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Dispense(amount);
            }
            else
            {
                 Console.WriteLine($"Cannot dispense £{amount} with available denominations.");
            }
        }
    }
}
