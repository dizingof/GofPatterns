class BasicRemote : RemoteControl
{
    private bool isOn = false;

    public BasicRemote(IDevice device) : base(device)
    {
    }

    public override void TogglePower()
    {
        if (isOn)
        {
            device.TurnOff();
            isOn = false;
        }
        else
        {
            device.TurnOn();
            isOn = true;
        }
    }
}