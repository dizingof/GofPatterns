using AbstractFactory.Details;

public class TruckEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Truck engine started.");
    }
}