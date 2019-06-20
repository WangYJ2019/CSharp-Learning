using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    // After the delegation, all functions with two integer inputs and one integer output in the system shall be delegated.
    public delegate int Int2Delegate(int x, int y);
    public delegate double Double2Delegate(double x, double y);
    public class Calculator
    {
        //private MathElem mathElem = new MathElem();  => This is for create an instance, not for static function.
        public static int IntCalc(int x, int y, Int2Delegate calc)  //specific a delegate.
        {
            return calc.Invoke(x, y);
        }
        public static double DoubleCalc(double x, double y, Double2Delegate calc2)  //specific a delegate.
        {
            return calc2.Invoke(x, y);
        }
    }
}
