using UnityEngine;

public class Ship : MonoBehaviour
{
    private IShipState currentState;

    private void Awake() 
    {
        currentState = new NormalShipState();
        currentState.Execute(this);
    }

    public void Normalize()
    {
        currentState = new NormalShipState();
        currentState.Execute(this);
    }

    public void TriggerRedAlert()
    {
        currentState = new AlertShipState();
        currentState.Execute(this);
    }

    public void DisableShip()
    {
        currentState = new DisabledShipState();
        currentState.Execute(this);
    }

    public void LogStatus(string status)
    {
        Debug.Log(status);
    }
}
