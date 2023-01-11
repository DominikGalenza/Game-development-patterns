using UnityEngine;

public class Buzzer : MonoBehaviour
{
    private void OnEnable() 
    {
        Timer.onTimerStarted += PlayStartBuzzer;
        Timer.onTimerEnded += PlayEndBuzzer;
    }

    private void OnDisable() 
    {
        Timer.onTimerStarted -= PlayStartBuzzer;
        Timer.onTimerEnded -= PlayEndBuzzer;
    }

    private void PlayStartBuzzer()
    {
        Debug.Log("[BUZZER] : Play start buzzer!");
    }

    private void PlayEndBuzzer()
    {
        Debug.Log("[BUZZER] : Play end buzzer!");
    }
}
