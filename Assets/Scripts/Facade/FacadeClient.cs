using UnityEngine;

public class FacadeClient : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = new Player();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SaveManager.Instance.SaveGame(player);
        }
    }
}
