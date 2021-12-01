﻿using System;

namespace HomeWork5Lib
{
    public class HomeWork5
    {
        public static int TwoDimensionalArrayMin(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                    A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            (int minIDi, int minIDj) = TwoDimensionalArrayMinID(A);
            return A[minIDi, minIDj];
        }

        public static int TwoDimensionalArrayMax(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            (int maxIDi, int maxIDj) = TwoDimensionalArrayMinID(A);
            return A[maxIDi, maxIDj];
        }

        public static (int minIDi, int minIDj) TwoDimensionalArrayMinID(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                    A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int minIDi = 0;
            int minIDj = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < A[minIDi, minIDj])
                    {
                        minIDi = i;
                        minIDj = j;
                    }
                }
            }

            return (minIDi, minIDj);
        }

        public static (int maxIDi, int maxIDj) TwoDimensionalArrayMaxID(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                 A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            int maxIDi = 0;
            int maxIDj = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > A[maxIDi, maxIDj])
                    {
                        maxIDi = i;
                        maxIDj = j;
                    }
                }
            }

            return (maxIDi, maxIDj);
        }

        public static int TwoDimensionalArrayCountBiggerThanNeighboors(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            int count = 0;
            int fLen = A.GetLength(0) - 1;
            int sLen = A.GetLength(1) - 1;
            for (int i = 0; i <= fLen; i++)
            {
                for (int j = 0; j <= sLen; j++)
                {
                    if ((i + 1 <= fLen && i - 1 >= 0)
                        && (j + 1 <= sLen && j - 1 >= 0))
                    {
                        if ((A[i, j] > A[i + 1, j])
                            && (A[i, j] > A[i - 1, j])
                            && (A[i, j] > A[i, j + 1])
                            && (A[i, j] > A[i, j - 1]))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        public static int[,] TwoDimensionalArrayMirror(int[,] A)
        {
            if (A.GetLength(0) == null || A.GetLength(1) == null ||
                A.GetLength(0) == 0 || A.GetLength(1) == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = i + 1; j < A.GetLength(1); j++)
                {
                    Swap(ref A[i, j], ref A[j, i]);
                }
            }

            return A;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
