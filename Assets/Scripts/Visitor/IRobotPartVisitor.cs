public interface IRobotPartVisitor
{
    void Visit(Robot robot);
    void Visit(Battery batter);
    void Visit(MechanicalArm mechanicalArm);
    void Visit(ThermalImager thermalImager);
}
