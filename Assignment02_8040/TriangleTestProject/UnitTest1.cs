using NUnit.Framework;
using System;
using Assignment02_8040;

namespace TriangleTestProject
{
    public class Tests
    {
        TriangleSolve myObj = new TriangleSolve();
        [Test]

        public void NegativeOneSide()
        {
            string a;
            a = myObj.Analyze(-5, 5, 5);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void NegativeTwoSide()
        {
            string a;
            a = myObj.Analyze(-10, -10, 5);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void NegativeThreeSide()
        {
            string a;
            a = myObj.Analyze(15, 15, -10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void ZeroOneSide()
        {
            string a;
            a = myObj.Analyze(0, 10, 10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void ZeroTwoSide()
        {
            string a;
            a = myObj.Analyze(0, 0, 10);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void ZeroThreeSide()
        {
            string a;
            a = myObj.Analyze(0, 0, 0);
            Assert.AreEqual(a, "Can not form Triangle.");
        }
        [Test]
        public void Isosceles()
        {
            string a;
            a = myObj.Analyse(5, 10, 10);
            Assert.AreEqual(a, "This is an isosceles triangle.");
        }
    }
}