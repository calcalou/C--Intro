using System;

namespace FormesGeometriques
{
    class Program
    {
        static void Main(string[] args)
        {

            Point O = new Point();
            Point A = new Point(2, 2);
            Point B = new Point(2, 2);

            Console.WriteLine("Classe Point :");
            Console.WriteLine($"O{O}");
            Console.WriteLine($"A{A}");
            Console.WriteLine($"B{B}");

            Console.WriteLine(A.Equals(B) ? "A et B sont égaux" : "A et B sont différents");
            Console.WriteLine(A.Equals(O) ? "A et O sont égaux" : "A et O sont différents");


            Cercle cercle = new Cercle(A, 10);
            Console.WriteLine("\nClasse Cercle :");
            Console.WriteLine(cercle);
            Console.WriteLine($"Perimetre : {cercle.Perimetre()}");
            Console.WriteLine($"Aire : {cercle.Aire()}");


            Rectangle rectangle = new Rectangle(A, 40, 10);
            Console.WriteLine("\nClasse Rectangle :");
            Console.WriteLine(rectangle);
            Console.WriteLine($"Perimetre : {rectangle.Perimetre()}");
            Console.WriteLine($"Aire : {rectangle.Aire()}");

            Console.ReadLine();
        }
    }
}
