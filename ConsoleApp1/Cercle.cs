using System;

public class Cercle : Forme
{
    public double Rayon { get; set; }

    public Cercle(Point point, double rayon) : base(point)
    {
        this.Rayon = rayon;
    }

    public override double Perimetre()
    {
        return 2 * Math.PI * Rayon;
    }

    public override double Aire()
    {
        return Math.PI * Math.Pow(Rayon, 2);
    }

    public override string ToString()
    {
        return $"Centre : {Point}, Rayon : {Rayon}";
    }
}
