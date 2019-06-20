using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Engine
    {
        public virtual void EngineRun()
        {
            Console.WriteLine("Engine is running!");
        }
    }

    public class EletricEngine : Engine
    {
        public override void EngineRun()
        {
            base.EngineRun();
            Console.WriteLine("This is electric engine!");
        }
    }

    public class GasEngine : Engine
    {
        public override void EngineRun()
        {
            base.EngineRun();
            Console.WriteLine("This is gas engine!");
        }
    }

    public class SolarEngine : Engine
    {
        public override void EngineRun()
        {
            base.EngineRun();
            Console.WriteLine("This is solar engine!");
        }
    }
}
