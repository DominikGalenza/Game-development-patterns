public class SideWinder : Missile
{
    private void Awake() 
    {
        this.seekBehaviour = new SeekWithHeat();
    }
}
