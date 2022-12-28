using UnityEngine;

public class AbstractFarmer : IHuman
{
    public void Speak()
    {
        Debug.Log("I once was an adventurer like you, then...");
    }
}
