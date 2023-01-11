using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningLight : MonoBehaviour
{
    private void OnEnable() 
    {
        Timer.onHalfTime += BlinkLight;
    }

    private void OnDisable() 
    {
        Timer.onHalfTime += BlinkLight;
    }

    private void BlinkLight()
    {
        Debug.Log("[WARNING LIGHT] : It's half time!");
    }
}
