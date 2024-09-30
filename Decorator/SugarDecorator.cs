public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Сахар";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.50; // Стоимость сахара
    }
}