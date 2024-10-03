namespace FormesGeometriques
{
    public class Rectangle : Forme
    {
        public double longueur { get; set; }
        public double largeur { get; set; }


        public Rectangle(Point point, double longueur, double largeur) : base(point)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public override double Perimetre()
        {
            return 2 * (longueur + largeur);
        }


        public override double Aire()
        {
            return longueur * largeur;
        }

        public override string ToString()
        {
            return $"Centre : {point}, Longueur : {longueur}, Largeur : {largeur}";
        }
    }
}
