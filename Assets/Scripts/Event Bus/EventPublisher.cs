using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            EventBus.TriggerEvent("Launch");
        }
    }
}
