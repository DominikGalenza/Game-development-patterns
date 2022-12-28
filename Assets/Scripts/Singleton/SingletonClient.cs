using UnityEngine;

public class SingletonClient : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameManager.Instance.InitialiseGame();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            InventoryManager.Instance.AddItem(1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            InventoryManager.Instance.RemoveItem(2);
        }
    }
}
