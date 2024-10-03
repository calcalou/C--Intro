using System;

namespace FormesGeometriques
{
    public class Cercle : Forme
    {
        public double rayon { get; set; }


        public Cercle(Point point, double rayon) : base(point)
        {
            this.rayon = rayon;
        }


        public override double Perimetre()
        {
            return 2 * Math.PI * rayon;
        }


        public override double Aire()
        {
            return Math.PI * rayon * rayon;
        }


        public override string ToString()
        {
            return $"Centre : {point}, Rayon : {rayon}";
        }
    }
}
