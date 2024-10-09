public class HighLevelHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine($"HighLevelHandler: Обработал запрос {request}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}