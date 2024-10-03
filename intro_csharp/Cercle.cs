using System;

namespace FormesGeometriques
{
    public class Cercle : Forme
    {
        public double rayon { get; set; }

        // Constructeur du Cercle
        public Cercle(Point point, double rayon) : base(point)
        {
            this.rayon = rayon;
        }

        // Implémentation de Perimetre
        public override double Perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        // Implémentation de Aire
        public override double Aire()
        {
            return Math.PI * rayon * rayon;
        }

        // Redéfinition de ToString
        public override string ToString()
        {
            return $"Centre : {point}, Rayon : {rayon}";
        }
    }
}
