public class Car
{
    public string Engine { get; set; }
    public int Doors { get; set; }
    public string Color { get; set; }

    public void ShowSpecifications()
    {
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Doors: {Doors}");
        Console.WriteLine($"Color: {Color}");
    }
}