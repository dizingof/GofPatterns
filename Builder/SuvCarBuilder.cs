public class SuvCarBuilder : ICarBuilder
{
    private Car car = new Car();

    public void SetEngine()
    {
        car.Engine = "V6 Engine";
    }

    public void SetDoors()
    {
        car.Doors = 4;
    }

    public void SetColor()
    {
        car.Color = "Black";
    }

    public Car GetCar()
    {
        return car;
    }
}