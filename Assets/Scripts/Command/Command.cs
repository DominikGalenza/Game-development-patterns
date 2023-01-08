abstract class Command
{
    protected CommandRemoteControlDevice receiver;

    public Command(CommandRemoteControlDevice receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
}
