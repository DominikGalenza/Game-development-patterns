using UnityEngine;

public class InventoryManager : Singleton<InventoryManager>
{
    public void AddItem(int itemID)
    {
        Debug.Log("Adding item to the inventory.");
    }

    public void RemoveItem(int itemID)
    {
        Debug.Log("Removing item from the inventory.");
    }
}
