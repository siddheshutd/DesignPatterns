namespace C_;

public class Toppings
{
}

public class CheeseBurst : ToppingsDecorator {
    new IBasePizza basePizza;
    public CheeseBurst(IBasePizza pizza) : base(pizza) {
        basePizza = pizza;
    }

    public override int GetCost(){
        return basePizza.GetCost() + 1;
    }
}

public class Jalapenos : ToppingsDecorator {
    new IBasePizza basePizza;
    public Jalapenos(IBasePizza pizza) : base(pizza) {
        basePizza = pizza;
    }

    public override int GetCost(){
        return basePizza.GetCost() + 1;
    }
}
