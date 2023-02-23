using UnityEngine;

public class HumanDriver : IDriver
{
    private Bike bike;

    public void Control(Bike bike)
    {
        this.bike = bike;
        Debug.Log("A player will control the bike.");
    }
}
