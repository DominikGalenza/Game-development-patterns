using System;
using UnityEngine;

public class Notifier : MonoBehaviour
{
    private void OnEnable() 
    {
        Timer.onTimerEnded += ShowGameOverPopUp;    
    }

    private void OnDisable() 
    {
        Timer.onTimerEnded -= ShowGameOverPopUp;
    }

    private void ShowGameOverPopUp()
    {
        Debug.Log("[NOTIFIER] : Show game over pop up!");
    }
}
