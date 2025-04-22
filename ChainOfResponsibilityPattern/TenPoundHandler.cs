using System;

namespace ChainOfResponsibilityPattern
{
    public class TenPoundHandler : WithdrawHandlerBase
    {
        public override void Dispense(int amount)
        {
            if (amount >= 10)
            {
                int numNotes = amount / 10;
                int remainder = amount % 10;
                Console.WriteLine($"Dispensing {numNotes} x £10 note(s)");

                if (remainder > 0 && _nextHandler != null)
                {
                    // In a real ATM, you might have a handler for smaller denominations or coins.
                    // For this example, we'll assume £10 is the smallest.
                    _nextHandler.Dispense(remainder);
                }
                else if (remainder > 0)
                {
                    Console.WriteLine($"Cannot dispense remaining £{remainder} with available denominations (£10 is the smallest).");
                }
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Dispense(amount);
            }
            else
            {
                 // If amount is less than 10 and there's no next handler
                 Console.WriteLine($"Cannot dispense £{amount} as £10 is the smallest denomination available.");
            }
        }
    }
}
