using Assignment02_8040;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        TriangleSolve myObj = new TriangleSolve();

        [Test]
        public void NegativeOneSide()
        {
            string a;
            a = myObj.Analyse(-5, 5, 5);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void NegativeTwoSide()
        {
            string a;
            a = myObj.Analyse(-10, -10, 5);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void NegativeThreeSide()
        {
            string a;
            a = myObj.Analyse(15, 15, -10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void ZeroOneSide()
        {
            string a;
            a = myObj.Analyse(0, 10, 10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void ZeroTwoSide()
        {
            string a;
            a = myObj.Analyse(0, 0, 10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void ZeroThreeSide()
        {
            string a;
            a = myObj.Analyse(0, 0, 0);
            Assert.AreEqual(a, "Can not form Triangle.");
        }

        [Test]
        public void Isosceles()
        {
            string a;
            a = myObj.Analyse(5, 10, 10);
            Assert.AreEqual(a, "This is an isosceles triangle.");
        }

        [Test]
        public void Equilateral()
        {
            string a;
            a = myObj.Analyse(10, 10, 10);
            Assert.AreEqual(a, "This is an equilateral triangle.");
        }

        [Test]
        public void Scalene()
        {
            string a;
            a = myObj.Analyse(15, 14, 6);
            Assert.AreEqual(a, "This is a scalene triangle.");
        }

    }
}
