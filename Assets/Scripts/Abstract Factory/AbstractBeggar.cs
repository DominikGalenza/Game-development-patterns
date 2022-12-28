using UnityEngine;

public class AbstractBeggar : IHuman
{
    public void Speak()
    {
        Debug.Log("Spare a coin, eh?");
    }
}
