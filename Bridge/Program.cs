IDevice tv = new TV();
IDevice radio = new Radio();

RemoteControl tvRemote = new BasicRemote(tv);
RemoteControl radioRemote = new BasicRemote(radio);

tvRemote.TogglePower();  // Включает телевизор
radioRemote.TogglePower();  // Включает радио

tvRemote.TogglePower();  // Выключает телевизор
radioRemote.TogglePower();  // Выключает радио