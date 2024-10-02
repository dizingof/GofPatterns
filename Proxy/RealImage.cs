public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine("Загрузка изображения с диска: " + _fileName);
    }

    public void Display()
    {
        Console.WriteLine("Отображение изображения: " + _fileName);
    }
}