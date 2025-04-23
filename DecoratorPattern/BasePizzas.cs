namespace DecoratorPattern;

public class BasePizzas
{

}

public class Margherita : IBasePizza
{
    public int GetCost()
    {
        return 5;
    }
}

public class VeggieDelight : IBasePizza
{
    public int GetCost()
    {
        return 7;
    }
}

public class ChickenDomniator : IBasePizza
{
    public int GetCost()
    {
        return 10;
    }
}