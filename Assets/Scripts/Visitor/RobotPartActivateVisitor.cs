using UnityEngine;

public class RobotPartActivateVisitor : IRobotPartVisitor
{
    public void Visit(Robot robot)
    {
        Debug.Log("Robot is waking up.");
    }

    public void Visit(Battery batter)
    {
        Debug.Log("Battery is charged up.");
    }

    public void Visit(MechanicalArm mechanicalArm)
    {
        Debug.Log("The mechanical arm is activated.");
    }

    public void Visit(ThermalImager thermalImager)
    {
        Debug.Log("The thermal imager is turned on.");
    }
}
