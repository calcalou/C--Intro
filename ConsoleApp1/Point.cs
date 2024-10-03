public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point() {}
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Points(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
    {
    return this.X == other.X && this.Y == other.Y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}