using AbstractFactory.Details;

public class CarEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Car engine started.");
    }
}
