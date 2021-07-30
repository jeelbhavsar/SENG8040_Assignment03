using NUnit.Framework;
using AwesomeCalculator;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {

        Calc calc = new Calc();

        [Test]
        public void UnitTest_Of_Addition()
        {
            double a = 1, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void UnitTest_Of_Addition_1()
        {
            double a = 2, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 6); //assert fail
        }
        [Test]
        public void UnitTest_Of_Addition_2()
        {
            double a = 5, b = 5;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 10); //assert
        }


        [Test]
        public void UnitTest_Of_Subtraction()
        {
            double a = 1, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 0); //assert
        }
        [Test]
        public void UnitTest_Of_Subtraction_1()
        {
            double a = 4, b = 2;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 2); //assert fail
        }
        [Test]
        public void UnitTest_Of_Subtraction_2()
        {
            double a = 6, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 3); //assert
        }

        [Test]
        public void UnitTest_Of_Multiplication()
        {
            double a = 1, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 1); //assert
        }
        [Test]
        public void UnitTest_Of_Multiplication_1()
        {
            double a = 2, b = 2;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 4); //assert fail
        }
        [Test]
        public void UnitTest_Of_Multiplication_2()
        {
            double a = 3, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 9); //assert
        }
        [Test]
        public void UnitTest_Of_Division()
        {
            double a = 10, b = 5;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void UnitTest_Of_Division_1()
        {
            double a = 70, b = 10;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 7); //assert fail
        }
        [Test]
        public void UnitTest_Of_Division_2()
        {
            double a = 80, b = 10;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 8); //assert
        }
        [Test]
        public void Mutation_Test()
        {
            double a = 1, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 0); //assert
        }

        [Test]
        public void Mutation_Test_1()
        {
            double a = 2, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void Mutation_Test_2()
        {
            double a = 9, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }
    }
}








