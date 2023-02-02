abstract public class RifleDecorator : IRifle
{
    protected IRifle decoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        decoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy();
    }
}
