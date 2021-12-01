using System;

namespace HomeWork2Lib
{
    public class HomeWork2
    {
        public static int Task1(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else if (A < B)
            {
                result = A - B;
            }
            return result;

        }

        public static int Task2(int X, int Y)
        {
            int result = 0;
            if (X > 0 && Y > 0)
            {
                result = 1;
            }
            else if (X < 0 && Y > 0)
            {
                result = 2;
            }
            else if (X < 0 && Y < 0)
            {
                result = 3;
            }
            else if (X > 0 && Y < 0)
            {
                result = 4;
            }
            else if (X == 0 && Y == 0)
            {
                result = 0;
            }
            return result;

        }

        public static void Task3(ref int A, ref int B, ref int C)
        {
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }
            if (A > C)
            {
                int temp = A;
                A = C;
                C = temp;
            }
            if (B > C)
            {
                int temp = B;
                B = C;
                C = temp;
            }
        }
        public static (double? X1, double? X2) Task4(double A, double B, double C)
        {
            double D = B * B - 4 * A * C;
            if (D == 0)
            {
                double x = -B / (2 * A);

                return (x, x);
            }
            else if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);

                return (x1, x2);
            }
            else
            {
                return (null, null);
            }
        }

        public static string SubTask5(string A)
        {
            int _A = Convert.ToInt32(A);
            string result = " ";
            switch (_A)
            {
                case 1:
                    {
                        result = "one";
                        break;
                    }
                case 2:
                    {
                        result = "two";
                        break;
                    }
                case 3:
                    {
                        result = "three";
                        break;
                    }
                case 4:
                    {
                        result = "four";
                        break;
                    }
                case 5:
                    {
                        result = "five";
                        break;
                    }
                case 6:
                    {
                        result = "six";
                        break;
                    }
                case 7:
                    {
                        result = "seven";
                        break;
                    }
                case 8:
                    {
                        result = "eight";
                        break;
                    }
                case 9:
                    {
                        result = "nine";
                        break;
                    }
            }
            return result;
        }

        public static string Task5(string A)
        {
            int _A = Convert.ToInt32(A);
            if (_A > 100 && _A < 10)
            {
                throw new ArgumentException("Value cannot be bigger than 100, and less then 10");
            }
            string result = null;
            switch (_A)
            {
                case 10:
                    {
                        result = "Ten";
                        break;
                    }
                case 11:
                    {
                        result = "Eleven";
                        break;
                    }
                case 12:
                    {
                        result = "Twelve";
                        break;
                    }
                case 13:
                    {
                        result = "Thirteen";
                        break;
                    }
                case 14:
                    {
                        result = "Fourteen";
                        break;
                    }
                case 15:
                    {
                        result = "Fiveteen";
                        break;
                    }
                case 16:
                    {
                        result = "Sixteen";
                        break;
                    }
                case 17:
                    {
                        result = "Seventeen";
                        break;
                    }
                case 18:
                    {
                        result = "Eighteen";
                        break;
                    }
                case 19:
                    {
                        result = "Nineteen";
                        break;
                    }
                case 20:
                    {
                        result = "Twenty";
                        break;
                    }
                case 30:
                    {
                        result = "Thirty";
                        break;
                    }
                case 40:
                    {
                        result = "Fourty";
                        break;
                    }
                case 50:
                    {
                        result = "Fifty";
                        break;
                    }
                case 60:
                    {
                        result = "Sixty";
                        break;
                    }
                case 70:
                    {
                        result = "Seventy";
                        break;
                    }
                case 80:
                    {
                        result = "Eighty";
                        break;
                    }
                case 90:
                    {
                        result = "Ninety";
                        break;
                    }
                default:
                    {
                        if (_A > 0)
                        {
                            result = Task5(A.Substring(0, 1) + "0") + " " + SubTask5(A.Substring(1));
                        }
                        break;
                    }
            }
            return result;
        }
    }
}
