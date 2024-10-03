using System;

namespace FormesGeometriques
{
    public abstract class Forme
    {
        public Point point { get; set; }


        public Forme(Point point)
        {
            this.point = point;
        }


        public abstract double Perimetre();
        public abstract double Aire();
    }
}
