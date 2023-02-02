public class WithScope : RifleDecorator
{
    private float scopeAccuracy = 20f;

    public WithScope(IRifle rifle) : base(rifle)
    {
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + scopeAccuracy;
    }
}
