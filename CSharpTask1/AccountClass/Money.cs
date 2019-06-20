using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsClass
{
    public class Money
    {
        private double faceValue;
        private Currency myCurrency;

        public double FaceValue
        {
            get => faceValue;
            set => faceValue = value;
        }
        public Currency MyCurrency
        {
            get => myCurrency;
            set => myCurrency = value;
        }
        //-----constructor-----
        public Money() : this(0, Currency.RMB)
        {
        }
        public Money(double faceValue) : this(faceValue, Currency.RMB)
        {
        }
        public Money(double faceValue, Currency currency)
        {
            this.faceValue = faceValue;
            this.myCurrency = currency;
        }

        //-----overload of the method-----
        public static Money operator + (Money m1, Money m2)
        {
            if (m1.MyCurrency == m2.MyCurrency)
            {
                double faceValue = m1.FaceValue + m2.FaceValue;
                // create the money object.
                return new Money(faceValue, m1.myCurrency);
            }
            else
            {
                // problem: remains to be solved...
                return (new Money(9999.9999, Currency.RMB));
            }
        }

        public static Money operator -(Money m1, Money m2)
        {
            if (m1.MyCurrency == m2.MyCurrency)
            {
                double faceValue = m1.FaceValue - m2.FaceValue;
                // create the money object.
                return new Money(faceValue, m1.myCurrency);
            }
            else
            {
                return (new Money(-9999.9999, Currency.RMB));
            }
        }

        public override string ToString()
        {
            return $"{this.faceValue} {this.myCurrency}";
        }
    }
}
