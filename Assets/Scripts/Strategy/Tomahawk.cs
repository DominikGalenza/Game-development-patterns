public class Tomahawk : Missile
{
    private void Awake() 
    {
        this.seekBehaviour = new SeekWithGPS();
    }
}
