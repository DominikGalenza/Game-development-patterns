using UnityEngine;

public class RobotPartShutdownVisitor : IRobotPartVisitor
{
    public void Visit(Robot robot)
    {
        Debug.Log("Robot is going back to sleep.");
    }

    public void Visit(Battery batter)
    {
        Debug.Log("Battery is charging down.");
    }

    public void Visit(MechanicalArm mechanicalArm)
    {
        Debug.Log("The mechanical arm is folding back to its default position.");
    }

    public void Visit(ThermalImager thermalImager)
    {
        Debug.Log("The thermal imager is turned off.");
    }
}
