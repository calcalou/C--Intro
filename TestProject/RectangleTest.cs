using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class TestsRectangle
    {
        [TestMethod]
        public void TestRectanglePerimetre()
        {
            Point A = new Point(2, 2);
            Rectangle rectangle = new Rectangle(A, 40, 10);

            double perimetre = rectangle.Perimetre();

            Assert.AreEqual(100, perimetre, "Le périmètre du rectangle est incorrect.");
        }

        [TestMethod]
        public void TestRectangleAire()
        {
            Point A = new Point(2, 2);
            Rectangle rectangle = new Rectangle(A, 40, 10);

            double aire = rectangle.Aire();

            Assert.AreEqual(400, aire, "L'aire du rectangle est incorrecte.");
        }

        [TestMethod]
        public void TestRectangleToString()
        {
            Point A = new Point(2, 2);
            Rectangle rectangle = new Rectangle(A, 40, 10);

            string result = rectangle.ToString();

            Assert.AreEqual("Centre : (2,2), Longueur : 40, Largeur : 10", result, "La méthode ToString() du rectangle ne retourne pas le format correct.");
        }
    }
}
