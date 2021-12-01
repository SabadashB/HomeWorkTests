using NUnit.Framework;
using HomeWork3Lib;
using System;

namespace HomeWork3UTest
{
    public class Tests
    {
        [TestCase(5, 2, 25)]
        [TestCase(-1, 4, 1)]
        [TestCase(-1, 3, -1)]
        [TestCase(0, 3, 0)]
        public void AtoPowerB_WhenABiggerTnenZeroAndBNotEqualZero_ShouldCalculatePower(int a, 
            int b, int expected)
        {
            int actualResults = HomeWork3.GetAToPowerB(a, b);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(0, -2)]
        public void AtoPowerB_WhenALessTnenZeroAndBEqualZero_ShouldShowMessage(int a, int b)
        {
            try
            {
                HomeWork3.GetAToPowerB(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Cannot power zero to negative degree", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(7, 142)]
        public void DividedbyA_WhenABiggerThenZero_ShouldCalculateDivider(int a, int expected)
        {
            int actualResults = HomeWork3.DividedbyA(a);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void DividedbyA_WhenALessThenZero_ShouldShowMessage(int a)
        {
            try
            {
                HomeWork3.DividedbyA(a);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("a cannot be less or equal zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }


        [TestCase(12, 3)]
        public void GetSquareLessA_WhenABiggerThenZero_ShouldCalculateCount(int a, int expected)
        {
            int actualResults = HomeWork3.GetSquareLessA(a);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void GetSquareLessA_WhenALessThenZero_ShouldShowMessage(int a)
        {
            try
            {
                HomeWork3.GetSquareLessA(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("a cannot be less or equal zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 15, 21)]
        [TestCase(15, 1, 21)]
        public void FromAtoBLessThen7_WhenANotEqualB_ShouldCalculateSum(int a, int b, int expected)
        {
            int actualResults = HomeWork3.GetSumAtoBdivide7(a, b);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(4, 4)]
        public void FromAtoBLessThen7_WhenAEqualB_ShouldShowMessage(int a, int b)
        {
            try
            {
                HomeWork3.GetSumAtoBdivide7(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A cannot be equal B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(7, 13)]
        public void GetNumberFibonachi_WnenNBiggerThanZero_ShouldCalculateNumber(int a, int expected)
        {
            int actualResults = HomeWork3.GetNumberFibonachi(a);

            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(0)]
        public void etNumberFibonachi_WnenNBiggerThanZero_ShouldShowMessage(int n)
        {
            try
            {
                HomeWork3.GetNumberFibonachi(n);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("N cannot be less than 1", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(123, 55, false)]
        [TestCase(153, 53, true)]
        public void FindSameNumbers(int a, int b, bool expected)
        {
            bool actualResults = HomeWork3.GetSameNumbers(a, b);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(22, 0)]
        [TestCase(32, 1)]
        [TestCase(33, 2)]
        [TestCase(-33, 2)]
        public void CountOf_OddInValue(int a, int expected)
        {
            int actualResults = HomeWork3.GetOddCount(a);
            Assert.AreEqual(expected, actualResults);
        }
    }
}