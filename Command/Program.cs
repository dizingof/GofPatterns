// Создаем получателя
using Command;

Light livingRoomLight = new Light();

// Создаем команды
ICommand turnOnLight = new TurnOnLightCommand(livingRoomLight);
ICommand turnOffLight = new TurnOffLightCommand(livingRoomLight);

// Создаем инициатора
RemoteControl remote = new RemoteControl();

// Выполняем команды
remote.SetCommand(turnOnLight);
remote.PressButton();

remote.SetCommand(turnOffLight);
remote.PressButton();

// Отменяем последнюю команду
remote.PressUndoButton();

Console.ReadLine();