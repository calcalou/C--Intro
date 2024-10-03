public abstract class Forme
{
    public Point Point { get; set; }
    
    public Forme(Point point)
    {
        this.Point = point;
    }

    public abstract double Perimetre();
    public abstract double Aire();
}
