public class Prey : IUnit
{
    private int square;

    public void AddToGrid(int square)
    {
        this.square = square;
    }

    public int GetGridPosition()
    {
        return square;
    }
}
