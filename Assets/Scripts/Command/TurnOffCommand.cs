class TurnOffCommand : Command
{
    public TurnOffCommand(CommandRemoteControlDevice receiver) : base(receiver)
    {

    }

    public override void Execute()
    {
        receiver.TurnOff();
    }
}
