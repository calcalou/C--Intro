public class Rectangle : Forme
{
    public double Longueur { get; set; }
    public double Largeur { get; set; }

    public Rectangle(Point point, double longueur, double largeur) : base(point)
    {
        this.Longueur = longueur;
        this.Largeur = largeur;
    }

    public override double Perimetre()
    {
        return 2 * (Longueur + Largeur);
    }

    public override double Aire()
    {
        return Longueur + Largeur;
    }

    public override string ToString()
    {
        return $"Centre : {Point}, Longueur : {Longueur}, Largeur : {Largeur}";
    }
}
