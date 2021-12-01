using NUnit.Framework;
using HomeWork4Lib;
using System;

namespace HomeWork4UTest
{
    public class Tests
    {
        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11 }, 1)]
        [TestCase(new[] { -22, 11 }, 0)]
        public void ArrayMinID_WhenNotNullArray_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.ArrayMinID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [Test]
        public void ArrayMinID_WhenNullArray_ShuldReturnExeption()
        {
            try
            {
                HomeWork4.ArrayMinID(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No min element in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11 }, 0)]
        [TestCase(new[] { -22, 11 }, 1)]
        public void ArrayMaxID_WhenNotNullArray_ShuldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.ArrayMaxID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [Test]
        public void ArrayMaxID_WhenNullArray_ShuldReturnExeption()
        {
            try
            {
                HomeWork4.ArrayMaxID(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No max element in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11 }, 22)]
        [TestCase(new[] { -22, 11 }, 11)]
        public void FoundMax_WhenNotNullArray_ShuldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.ArrayMax(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11 }, 11)]
        [TestCase(new[] { -22, 11 }, -22)]
        public void FoundMin_WhenNotNullArray_ShuldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.ArrayMin(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11, 5 }, 27)]
        [TestCase(new[] { -22, 11, 5 }, -17)]
        public void SumOfOddID_WhenNotNullArray_ShuldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.SumOddID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11, 5 }, 2)]
        [TestCase(new[] { -22, 11, 6 }, 1)]
        public void CountOfOdd_WhenNotNullArray_ShuldReturnValue(int[] array, int expected)
        {
            int actualResults = HomeWork4.CountOdd(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22, 12 }, new[] { 12, 22 })]
        public void ArrayReverse_WhenNotNullArray_ShuldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = HomeWork4.ArrayReverse(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22, 12, 15 }, new[] { 15, 12, 22 })]
        [TestCase(new[] { 22, 12 }, new[] { 12, 22 })]
        public void ArrayHalfSwap_WhenNotNullArray_ShuldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = HomeWork4.ArrayHalfSwap(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 1, 5, 4, 3, 2 }, new[] { 5, 4, 3, 2, 1 })]
        public void ArraySortBubleUp_WhenNotNullArray_ShuldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = HomeWork4.ArrayBubleSortDown(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 1, 5, 4, 3, 2 }, new[] { 1, 2, 3, 4, 5 })]
        public void ArrayInsertBubleUp_WhenNotNullArray_ShuldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = HomeWork4.ArrayInsertSortUp(array);
            Assert.AreEqual(expected, actualResults);
        }
    }
}