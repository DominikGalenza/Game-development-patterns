using UnityEngine;

public class ServiceLocatorClient : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ServiceLocator.Instance.GetService<LightingCoordinator>().TurnOffLights();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ServiceLocator.Instance.GetService<CurrencyConverter>().ConvertToUsDollar(100);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ServiceLocator.Instance.GetService<LobbyCoordinator>().AddPlayerToLobby();
        }
    }
}
