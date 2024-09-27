public class ProductGroup : IProduct
{
    private List<IProduct> _products = new List<IProduct>();
    private string _groupName;

    public ProductGroup(string groupName)
    {
        _groupName = groupName;
    }

    public void AddProduct(IProduct product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        _products.Remove(product);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Группа продуктов: {_groupName}");
        foreach (var product in _products)
        {
            product.DisplayInfo();
        }
    }

    public decimal GetPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetPrice();
        }
        return total;
    }
}