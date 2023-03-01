using System;
using System.Linq;

public class Grid
{
    private int squareSize;
    private int numberOfSquares;

    public Grid(int squareSize, int numberOfSquares)
    {
        this.squareSize = squareSize;
        this.numberOfSquares = numberOfSquares;
    }

    public void AddToRandomPosition(IUnit unit)
    {
        unit.AddToGrid(UnityEngine.Random.Range(0, numberOfSquares));
    }

    public int FindClosest(IUnit referenceUnit, IUnit[] list)
    {
        if (list != null)
        {
            var points = list.Select(a => a.GetGridPosition()).ToList();
            var nearest = points.OrderBy(x => Math.Abs(x - referenceUnit.GetGridPosition())).First();
            return nearest;
        }
        else
        {
            throw new ArgumentException("Parameters cannot be null", "list");
        }
    }
}
