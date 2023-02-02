public class WithStabilizer : RifleDecorator
{
    private float stabilizerAccuracy = 10f;

    public WithStabilizer(IRifle rifle) : base(rifle)
    {
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + stabilizerAccuracy;
    }
}
