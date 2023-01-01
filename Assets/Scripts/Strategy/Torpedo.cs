public class Torpedo : Missile
{
    private void Awake() 
    {
        this.seekBehaviour = new SeekWithSonar();
    }
}
