using UnityEngine;

public class AbstractClient : MonoBehaviour
{
    public AbstractNPCSpawner spawner;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawner.SpawnHumans();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            spawner.SpawnAnimals();
        }
    }
}
