// Создаем Proxy вместо непосредственной работы с RealImage
IImage image = new ProxyImage("photo.jpg");

// При первом вызове, изображение загружается и отображается
image.Display();
Console.WriteLine("");

// При последующих вызовах изображение не загружается повторно
image.Display();

Console.ReadLine();