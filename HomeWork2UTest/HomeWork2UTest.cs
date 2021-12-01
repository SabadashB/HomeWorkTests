using NUnit.Framework;
using HomeWork2Lib;
using System;

namespace HomeWork2UTest
{
    public class Tests
    {
        [TestCase(4, 2, 6)]
        [TestCase(4, 4, 16)]
        [TestCase(2, 4, -2)]
        public void Task6_NormalValues_ShouldCalculateEquation(int a, int b, int Expected)
        {
            int actualResults = HomeWork2.Task1(a, b);

            Assert.AreEqual(Expected, actualResults);
        }

        [TestCase(2, 2, 1)]
        [TestCase(-1, 2, 2)]
        [TestCase(-3, -4, 3)]
        [TestCase(4, -4, 4)]
        public void Task7_NormalValues_ShouldCalculateQuarter(int x, int y, int Expected)
        {
            int actualResults = HomeWork2.Task2(x, y);

            Assert.AreEqual(Expected, actualResults);
        }

        [TestCase(4, 2, 4, null, null)]
        [TestCase(2, 5, -3, 0.5, -3)]
        [TestCase(1, -6, 9, 3, 3)]
        public void Task9_NormalValues_ShouleCalculateQuadraticEquation(double a, double b, double c,
            double? x1Expected, double? x2Expected)
        {
            (double? x1Result, double? x2Result) = HomeWork2.Task4(a, b, c);

            Assert.AreEqual(x1Expected, x1Result);
            Assert.AreEqual(x2Expected, x2Result);
        }

        [TestCase("25", "Twenty five")]
        public void Task10_NormalValues_ShouleTransformValueToText(string a, string expected)
        {
            string actualResult = HomeWork2.Task5(a);

            Assert.AreEqual(expected, actualResult);
        }

        [TestCase("101")]
        [TestCase("5")]
        public void Task10_NotNormalValues_ShouleTransformValueToText(string a)
        {
            try
            {
                HomeWork2.Task5(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Value cannot be bigger than 100, and less then 10", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

    }
}