namespace C_;

public abstract class ToppingsDecorator : IBasePizza
{
    protected IBasePizza basePizza;
    public ToppingsDecorator(IBasePizza basePizza){
        this.basePizza = basePizza;
    }
    public virtual int GetCost()
    {
        return basePizza.GetCost();
    }
}
