using AbstractFactory.Details;

public class TruckBody : IBody
{
    public void CreateBody()
    {
        Console.WriteLine("Truck body created.");
    }
}