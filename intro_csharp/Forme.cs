using System;

namespace FormesGeometriques
{
    public abstract class Forme
    {
        public Point point { get; set; }

        // Constructeur de la classe Forme
        public Forme(Point point)
        {
            this.point = point;
        }

        // Méthodes abstraites pour calculer le périmètre et l'aire
        public abstract double Perimetre();
        public abstract double Aire();
    }
}
