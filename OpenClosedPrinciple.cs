namespace C_;

public interface IDiscountStrategy{//Use Strategy Pattern
    public double CalculateDiscount(double amount);
}

public class OpenClosedPrinciple
{
    public class NormalCustomerDiscount : IDiscountStrategy{
        public double CalculateDiscount(double amount){
            return amount * 0.1;
        }
    }

    public class PremiumCustomerDiscount : IDiscountStrategy{
        public double CalculateDiscount(double amount){
            return amount * 0.25;
        }
    }

    public class DiscountCalculator{
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(double amount)
        {
            return _discountStrategy.CalculateDiscount(amount);
        }
    }
}
