using UnityEngine;

class TelevisionReceiver : CommandRemoteControlDevice
{
    public override void TurnOff()
    {
        Debug.Log("TV turned off.");
    }

    public override void TurnOn()
    {
        Debug.Log("TV turned on.");
    }
}
