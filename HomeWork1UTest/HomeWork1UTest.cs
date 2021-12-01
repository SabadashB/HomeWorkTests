using NUnit.Framework;
using HomeWork1Lib;
using System;

namespace HomeWork1UTest
{
    public class HomeWork1UTest
    {
        [TestCase(2, 4, 13)]
        [TestCase(4, 3, -29)]
        [TestCase(6, 8, 47)]
        [TestCase(-2, -4, -3)]
        public void Task1_WhenBIsNotEqualToA_ShouldCalculateEquation(int a, int b, double expected)
        {
            double actualResults = HomeWork1.Task1(a, b);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(2)]
        public void Task1_WhenBIsEqualToA_ShouldShowMessage(int a)
        {
            try
            {
                HomeWork1.Task1(a, a);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("(B - A) cannot be zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(8, 4, 2, 0)]
        [TestCase(5, 8, 0, 5)]
        [TestCase(-4, -2, 2, 0)]
        [TestCase(-5, -8, 0, -5)]
        public void Task3_WhenNormalValues_ShouldCalculateDivision_And_Remainder(int a, int b, int divisionExpected,
            int remainderExpected)
        {
            (int divisionActualResults, int remainderActualResults) = HomeWork1.Task3(a, b);

            Assert.AreEqual(divisionExpected, divisionActualResults);
            Assert.AreEqual(remainderExpected, remainderActualResults);
        }

        [TestCase(8, 0)]
        public void Task3_WhenBIsEqualToZero_ShouldShowMessage(int a, int b)
        {
            try
            {
                HomeWork1.Task3(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Ñannot using zero vlues!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(2, 4, 8, 2)]
        public void Task4_WhenAnotEquaZero_ShouldCalculateEquation(double a, double b, double c, double expected)
        {
            double actualResults = HomeWork1.Task4(a, b, c);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(0, 2, 4)]
        public void Task4_WhenAEquaZero_ShouldShowMessage(int a, int b, int c)
        {
            try
            {
                HomeWork1.Task4(a, b, c);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("A cannot be zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(4, 2, 8, 2, 0, 2)]
        public void Task5_WhenX1MinusX2NotEqualZero_ShouleCalculate(double x1, double y1, double x2, double y2, double x1Expected,
            double x2Expected)
        {
            (double x1Result, double x2Result) = HomeWork1.Task5(x1, y1, x2, y2);

            Assert.AreEqual(x1Expected, x1Result);
            Assert.AreEqual(x2Expected, x2Result);
        }

        [TestCase(2, 8, 2, 2)]
        public void Task5_WhenX1MinusX2EqualZero_ShouldShowMessage(double x1, double y1, 
            double x2, double y2)
        {
            try
            {
                HomeWork1.Task5(x1, y1, x2, y2);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("X1 and X2 cannot be zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}