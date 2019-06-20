using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Car
    {
        private Engine engine;

        public Car(Engine engine)
        {
            this.engine = engine;
            this.engine.EngineRun();
            Console.WriteLine("Car is running");
        }
    }
}
