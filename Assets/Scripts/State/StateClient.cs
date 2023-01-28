using UnityEngine;

public class StateClient : MonoBehaviour
{
    public Ship ship;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ship.Normalize();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ship.TriggerRedAlert();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ship.DisableShip();
        }
    }
}
