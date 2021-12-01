using NUnit.Framework;
using HomeWork5Lib;
using System;

namespace HomeWork5UTest
{
    public class Tests
    {
        [TestCaseSource(nameof(MinICases))]
        public void ArrayMinID_WhenNotNullArray_ShouldReturnValue(int[,] array, (int, int) ExpectedResults)
        {
            var actualResults = HomeWork5.TwoDimensionalArrayMinID(array);
            Assert.AreEqual(ExpectedResults, actualResults);
        }

        [Test]
        public void ArrayMinID_WhenNullArray_ShuldReturnExeption()
        {
            try
            {
                HomeWork5.TwoDimensionalArrayMinID(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(MinCases))]
        public void ArrayMin_WhenNotNullArray_ShouldReturnValue(int[,] array, int ExpectedResults)
        {
            int actualResults = HomeWork5.TwoDimensionalArrayMin(array);
            Assert.AreEqual(ExpectedResults, actualResults);
        }

        [TestCaseSource(nameof(MaxICases))]
        public void ArrayMaxID_WhenNotNullArray_ShouldReturnValue(int[,] array, (int, int) ExpectedResults)
        {
            var actualResults = HomeWork5.TwoDimensionalArrayMaxID(array);
            Assert.AreEqual(ExpectedResults, actualResults);
        }

        [TestCaseSource(nameof(MinCases))]
        public void ArrayMax_WhenNotNullArray_ShouldReturnValue(int[,] array, int ExpectedResults)
        {
            int actualResults = HomeWork5.TwoDimensionalArrayMax(array);
            Assert.AreEqual(ExpectedResults, actualResults);
        }

        [TestCaseSource(nameof(SwapCases))]
        public void ArraySwap_WhenNotNullArray_ShouldReturnArray(int[,] array, int[,] ExpectedResults)
        {
            int[,] actualResults = HomeWork5.TwoDimensionalArrayMirror(array);
            Assert.AreEqual(ExpectedResults, actualResults);
        }

        static object[] MinICases =
        {
            new object[]{
                new int[,] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (0,2)
            }
        };

        static object[] MinCases =
        {
            new object[]{
                new int[,] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1
            }
        };

        static object[] MaxICases =
{
            new object[]{
                new int[,] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (2,2)
            }
        };

        static object[] MaxCases =
        {
            new object[]{
                new int[,] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                9
            }
        };
        static object[] SwapCases =
{
            new object[]{
                new int[,] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                new int[,] { { 3, 4, 7 }, { 2, 5, 8 }, { 1, 6, 9 } },
            }
        };

    }
}