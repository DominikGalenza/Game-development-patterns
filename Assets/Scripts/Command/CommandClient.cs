using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandClient : MonoBehaviour
{
    private CommandRemoteControlDevice radioReceiver;
    private CommandRemoteControlDevice televisionReceiver;
    private CommandRemoteControlDevice[] devices = new CommandRemoteControlDevice[2];

    private void Start() 
    {
        radioReceiver = new RadioReceiver();
        televisionReceiver = new TelevisionReceiver();

        devices[0] = radioReceiver;
        devices[1] = televisionReceiver;
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Command commandRadio = new TurnOnCommand(devices[0]);
            Command commandTelevision = new TurnOnCommand(devices[1]);

            Invoker invoker = new Invoker();
            invoker.SetCommand(commandRadio);
            invoker.ExecuteCommand();

            invoker.SetCommand(commandTelevision);
            invoker.ExecuteCommand();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Command commandKill = new KillSwitchCommand(devices);
            Invoker invoker = new Invoker();

            invoker.SetCommand(commandKill);
            invoker.ExecuteCommand();
        }
    }
}
