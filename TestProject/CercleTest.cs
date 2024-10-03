using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class TestsCercle
    {
        [TestMethod]
        public void TestCerclePerimetre()
        {
            Point A = new Point(2, 2);
            Cercle cercle = new Cercle(A, 10);

            double perimetre = cercle.Perimetre();

            Assert.AreEqual(62.8318530717959, perimetre, 0.0001, "Le périmètre calculé est incorrect.");
        }

        [TestMethod]
        public void TestCercleAire()
        {
            Point A = new Point(2, 2);
            Cercle cercle = new Cercle(A, 10);

            double aire = cercle.Aire();

            Assert.AreEqual(314.159265358979, aire, 0.0001, "L'aire calculé est incorrecte.");
        }

        [TestMethod]
        public void TestCercleToString()
        {
            Point A = new Point(2, 2);
            Cercle cercle = new Cercle(A, 10);

            string result = cercle.ToString();

            Assert.AreEqual("Centre : (2,2), Rayon : 10", result, "La méthode ToString() du cercle ne retourne pas le format correct.");
        }
    }
}
