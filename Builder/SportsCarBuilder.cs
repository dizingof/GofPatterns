public class SportsCarBuilder : ICarBuilder
{
    private Car car = new Car();

    public void SetEngine()
    {
        car.Engine = "V8 Engine";
    }

    public void SetDoors()
    {
        car.Doors = 2;
    }

    public void SetColor()
    {
        car.Color = "Red";
    }

    public Car GetCar()
    {
        return car;
    }
}