using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classe Point :");
        Point O = new Point(0, 0);
        Point A = new Point(2, 2);
        Point B = new Point(2, 2);

        Console.WriteLine($"O{O}");
        Console.WriteLine($"A{A}");
        Console.WriteLine($"B{B}");

        if (A.Equals(B))
            Console.WriteLine("A et B sont égaux");
        else
            Console.WriteLine("A et B sont différents");

        if (A.Equals(O))
            Console.WriteLine("A et O sont égaux");
        else
            Console.WriteLine("A et O sont différents");

        Console.WriteLine("\nClasse Cercle :");
        Cercle cercle = new Cercle(A, 10);
        Console.WriteLine(cercle.ToString());
        Console.WriteLine($"Perimetre : {cercle.Perimetre()}");
        Console.WriteLine($"Aire : {cercle.Aire()}");

        Console.WriteLine("\nClasse Rectangle :");
        Rectangle rectangle = new Rectangle(A, 40, 10);
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine($"Perimetre : {rectangle.Perimetre()}");
        Console.WriteLine($"Aire : {rectangle.Aire()}");
        Console.ReadLine();
    }
}