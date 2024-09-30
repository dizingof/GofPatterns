public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Молоко";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 1.50; // Стоимость молока
    }
}