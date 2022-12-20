using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone drone;
    public Sniper sniper;
    public EnemySpawner enemySpawner;

    private Enemy spawn;
    private int incrementorDrone = 0;
    private int incrementorSniper = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawn = enemySpawner.SpawnEnemy(drone);
            spawn.name = "Drone Clone " + ++incrementorDrone;
            spawn.transform.Translate(Vector3.up * incrementorDrone * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            spawn = enemySpawner.SpawnEnemy(sniper);
            spawn.name = "Sniper Clone " + ++incrementorSniper;
            spawn.transform.Translate(Vector3.forward * incrementorSniper * 1.5f);
        }
    }
}
