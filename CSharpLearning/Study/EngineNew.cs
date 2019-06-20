using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public abstract class EngineBase
    {
        public void Launch()
        {
            this.EngineOn();
            this.EngineShow();
        }
        private void EngineOn()
        {
            Console.WriteLine("Switch ON the Engine!");
        }
        protected abstract void EngineShow();//virtual method, no inputs
    }

    public class EletricEngineNew : EngineBase
    {
        protected override void EngineShow()
        {
            Console.WriteLine("This is electric engine!");
        }
    }

    public class GasEngineNew : EngineBase
    {
        protected override void EngineShow()
        {
            Console.WriteLine("This is gas engine!");
        }
    }

    public class SolarEngineNew : EngineBase
    {
        protected override void EngineShow()
        {
            Console.WriteLine("This is solar engine!");
        }
    }
}
