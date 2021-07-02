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

    }
}