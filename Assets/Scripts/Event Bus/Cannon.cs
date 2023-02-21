using UnityEngine;

public class Cannon : MonoBehaviour
{
    private bool isQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Shoot", Shoot);
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    private void OnDisable()
    {
        if (isQuitting == false)
        {
            EventBus.StopListening("Shoot", Shoot);
        }
    }

    private void Shoot()
    {
        Debug.Log("Received a shoot event: shooting cannon!");
    }
}
