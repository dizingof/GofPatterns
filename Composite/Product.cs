public class Product : IProduct
{
    private string _name;
    private decimal _price;

    public Product(string name, decimal price)
    {
        _name = name;
        _price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Продукт: {_name}, Цена: {_price:C}");
    }

    public decimal GetPrice()
    {
        return _price;
    }
}