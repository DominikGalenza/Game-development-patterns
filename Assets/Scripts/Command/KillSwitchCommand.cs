class KillSwitchCommand : Command
{
    private CommandRemoteControlDevice[] devices;
    private static CommandRemoteControlDevice receiver;

    public KillSwitchCommand(CommandRemoteControlDevice[] devices) : base(receiver)
    {
        this.devices = devices;
    }

    public override void Execute()
    {
        foreach(CommandRemoteControlDevice device in devices)
        {
            device.TurnOff();
        }
    }
}
