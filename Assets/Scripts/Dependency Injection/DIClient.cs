using UnityEngine;

public class DIClient : MonoBehaviour
{
    public Bike playerBike;
    public Bike androidBike;

    private void Awake()
    {
        IEngine jetEngine = new JetEngine();
        IDriver humanDriver = new HumanDriver();

        playerBike.SetEngine(jetEngine);
        playerBike.SetDriver(humanDriver);
        playerBike.StartEngine();

        IEngine nitroEngine = new NitroEngine();
        IDriver androidDriver = new AndroidDriver();

        androidBike.SetEngine(nitroEngine);
        androidBike.SetDriver(androidDriver);
        androidBike.StartEngine();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerBike.TurnLeft();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerBike.TurnRight();
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT.");
        GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console.");
    }
}
