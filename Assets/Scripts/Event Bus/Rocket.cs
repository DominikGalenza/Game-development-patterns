using UnityEngine;

public class Rocket : MonoBehaviour
{
    private bool isQuitting;
    private bool isLaunched = false;

    private void OnEnable()
    {
        EventBus.StartListening("Launch", Launch);
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    private void OnDisable()
    {
        if (isQuitting == false)
        {
            EventBus.StopListening("Launch", Launch);
        }
    }

    private void Launch()
    {
        if (isLaunched == false)
        {
            isLaunched = true;
            Debug.Log("Received a launch event: rocket launching!");
        }
    }
}
