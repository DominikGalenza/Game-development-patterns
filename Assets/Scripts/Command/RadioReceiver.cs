using UnityEngine;

class RadioReceiver : CommandRemoteControlDevice
{
    public override void TurnOff()
    {
        Debug.Log("Radio is turned off.");
    }

    public override void TurnOn()
    {
        Debug.Log("Radio is turned on.");
    }
}
