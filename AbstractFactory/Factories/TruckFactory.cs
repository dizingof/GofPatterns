using AbstractFactory.Details;

public class TruckFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new TruckEngine();
    }

    public IBody CreateBody()
    {
        return new TruckBody();
    }
}