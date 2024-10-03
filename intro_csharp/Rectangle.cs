namespace FormesGeometriques
{
    public class Rectangle : Forme
    {
        public double longueur { get; set; }
        public double largeur { get; set; }

        // Constructeur du Rectangle
        public Rectangle(Point point, double longueur, double largeur) : base(point)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        // Implémentation de Perimetre
        public override double Perimetre()
        {
            return 2 * (longueur + largeur);
        }

        // Implémentation de Aire
        public override double Aire()
        {
            return longueur * largeur;
        }

        // Redéfinition de ToString
        public override string ToString()
        {
            return $"Centre : {point}, Longueur : {longueur}, Largeur : {largeur}";
        }
    }
}
