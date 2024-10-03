using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class TestsPoint
    {
        [TestMethod]
        public void TestPointsEquals()
        {
            Point A = new Point(2, 2);
            Point B = new Point(2, 2);

            bool areEquale = A.Equals(B);

            Assert.IsTrue(areEquale, "Les points A et B devraient être égaux.");
        }

        [TestMethod]
        public void TestPointsNotEqual()
        {
            Point A = new Point(2, 2);
            Point O = new Point(0, 0);

            bool areEquale = A.Equals(O);

            Assert.IsFalse(areEquale, "Les points A et O ne devraient pas être égaux.");
        }

        [TestMethod]
        public void TestPointsToString()
        {
            Point A = new Point(2, 2);

            string result = A.ToString();

            Assert.AreEqual("(2, 2)", result, "La méthode ToString() ne retourne pas le bon format.");
        }
    }
}
