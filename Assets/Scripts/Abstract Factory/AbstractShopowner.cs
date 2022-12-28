using UnityEngine;

public class AbstractShopowner : IHuman
{
    public void Speak()
    {
        Debug.Log("I sell only finest merchandise!");
    }
}
