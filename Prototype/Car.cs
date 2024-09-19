public class Car : IPrototype<Car>
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }

    public Car(string model, string color, int horsePower)
    {
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public Car Clone()
    {
        return (Car)this.MemberwiseClone();
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Car Model: {Model}, Color: {Color}, HorsePower: {HorsePower}");
    }
}