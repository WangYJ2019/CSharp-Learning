using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    //only one void method => Launch()
    public delegate void OnLaunchHandler();

    public class CarNew
    {
        // the delegate is based upon the function, no matter what the class is.
        //  the method can from different classes. but must in the same namespace of the delegation.
        public void run(OnLaunchHandler handler)
        {
            handler();
            Console.WriteLine("Car is running");
        }
    }
}
