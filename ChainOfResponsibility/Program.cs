// Создаем обработчики
var lowLevelHandler = new LowLevelHandler();
var midLevelHandler = new MidLevelHandler();
var highLevelHandler = new HighLevelHandler();

// Формируем цепочку: low -> mid -> high
lowLevelHandler.SetNext(midLevelHandler);
midLevelHandler.SetNext(highLevelHandler);

// Тестовые запросы
int[] requests = { 5, 12, 25, 7, 18, 30 };

foreach (var request in requests)
{
    Console.WriteLine($"Запрос: {request}");
    lowLevelHandler.HandleRequest(request);
}

Console.ReadLine();