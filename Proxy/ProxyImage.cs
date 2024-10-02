public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        // Если изображение ещё не загружено, загружаем его
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        // Затем вызываем метод отображения
        _realImage.Display();
    }
}