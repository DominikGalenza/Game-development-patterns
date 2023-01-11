using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    private float duration = 10f;
    private float halfTime;
    private IEnumerator coroutine;

    public delegate void TimerStarted();
    public static event TimerStarted onTimerStarted;

    public delegate void HalfTime();
    public static event HalfTime onHalfTime;

    public delegate void TimerEnded();
    public static event TimerEnded onTimerEnded;

    private IEnumerator Start() 
    {
        halfTime = duration / 2;

        if (onTimerStarted != null)
        {
            onTimerStarted();
        }

        yield return StartCoroutine(WaitAndPrint(1f));

        if (onTimerEnded != null)
        {
            onTimerEnded();
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (Time.time < duration)
        {
            yield return new WaitForSeconds(waitTime);

            Debug.Log("Seconds " + Mathf.Round(Time.time));

            if (Mathf.Round(Time.time) == Mathf.Round(halfTime))
            {
                if (onHalfTime != null)
                {
                    onHalfTime();
                }
            }
        }
    }
}
