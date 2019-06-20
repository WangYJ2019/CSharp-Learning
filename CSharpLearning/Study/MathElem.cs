using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{

    public class MathElem
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0.0) return 0.0;
            return 1.0 * x / y;
        }
    }
}
