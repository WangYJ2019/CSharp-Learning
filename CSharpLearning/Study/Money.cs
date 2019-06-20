using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Money
    {
        private double faceValue;
        private Currency moneyType;

        public Money() : this(0, Currency.RMB)
        {
        }
        public Money(double faceValue):this(faceValue, Currency.RMB)
        {
        }
        public Money(double faceValue, Currency moneyType)
        {
            this.faceValue = faceValue;
            this.moneyType = moneyType;
        }
        public void ShowMoney()
        {
            Console.WriteLine($"I have {this.faceValue} {this.moneyType}.");
        }
    }
}
