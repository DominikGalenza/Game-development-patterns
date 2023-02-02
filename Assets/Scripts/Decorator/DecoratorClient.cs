using UnityEngine;

public class DecoratorClient : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log($"Basic accuracy: {rifle.GetAccuracy()}");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log($"Accuracy with scope: {rifle.GetAccuracy()}");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log($"Accuracy with scope and stabilizer: {rifle.GetAccuracy()}");
        }
    }
}
