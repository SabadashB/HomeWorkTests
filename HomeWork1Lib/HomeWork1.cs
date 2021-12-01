using System;

namespace HomeWork1Lib
{
    public class HomeWork1
    {
        public static double Task1(int A, int B)
        {
            if ((B - A) == 0)
            {
                throw new DivideByZeroException("(B - A) cannot be zero!");
            }

            return (5 * A + B * B) / (B - A);
        }

        public static void Task2(ref string A, ref string B)
        {
            string temp = A;
            A = B;
            B = temp;
        }

        public static (int division, int remainder) Task3(int A, int B)
        {
            if (B == 0)
            {
                throw new DivideByZeroException("Сannot using zero vlues!");
            }

            return (A / B, A % B);
        }

        public static double Task4(double A, double B, double C)
        {
            if (A == 0)
            {
                throw new DivideByZeroException("A cannot be zero!");
            }

            return (C - B) / A;
        }

        public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
        {
            if (X1 - X2 == 0)
            {
                throw new DivideByZeroException("X1 and X2 cannot be zero!");
            }

            double A = (Y1 - Y2) / (X1 - X2);
            double B = Y2 - A * X2;

            return (A, B);
        }
    }
}
