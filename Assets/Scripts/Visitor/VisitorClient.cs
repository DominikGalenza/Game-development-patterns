using UnityEngine;

public class VisitorClient : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IRobotPart robot = new Robot();
            robot.Accept(new RobotPartActivateVisitor());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            IRobotPart robot = new Robot();
            robot.Accept(new RobotPartShutdownVisitor());
        }
    }
}
