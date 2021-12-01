using System;

namespace HomeWork4Lib
{
    public class HomeWork4
    {
        public static int ArrayMin(int[] A)
        {
            return A[ArrayMinID(A)];
        }

        public static int ArrayMax(int[] A)
        {
            return A[ArrayMaxID(A)];
        }

        public static int ArrayMinID(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No min element in empty array");
            }

            int minID = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < A[minID])
                {
                    minID = i;
                }
            }

            return minID;
        }

        public static int ArrayMaxID(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No max element in empty array");
            }

            int maxID = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A[maxID])
                {
                    maxID = i;
                }
            }

            return maxID;
        }

        public static int SumOddID(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No odd element in empty array");
            }

            int sum = 0;
            for (int i = 0; i < A.Length; i += 2)
            {
                sum += A[i];
            }

            return sum;
        }

        public static int[] ArrayReverse(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int i = 0;
            int j = A.Length - 1;
            for (i = 0; i < j; i++)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            return A;
        }

        public static int CountOdd(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No odd element in empty array");
            }

            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ArrayHalfSwap(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int count1 = 0;
            int count2 = (A.Length + 1) / 2;
            for (int i = count2; i < A.Length; i++)
            {
                int temp = A[count1];
                A[count1] = A[count2];
                A[count2] = temp;
                count1++;
                count2++;
            }
            return A;
        }

        public static int[] ArrayBubleSortDown(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            return A;
        }

        public static int[] ArrayInsertSortUp(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];
                int j = i;
                while ((j > 1) && (A[j - 1] > key))
                {
                    Swap(ref A[j - 1], ref A[j]);
                    j--;
                }

                A[j] = key;
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
