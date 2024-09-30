public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Простой кофе";
    }

    public double GetCost()
    {
        return 5.00; // Базовая цена
    }
}