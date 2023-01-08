class TurnOnCommand : Command
{
    public TurnOnCommand(CommandRemoteControlDevice receiver) : base(receiver)
    {

    }

    public override void Execute()
    {
        receiver.TurnOn();
    }
}
