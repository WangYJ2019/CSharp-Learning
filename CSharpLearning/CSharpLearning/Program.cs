using System;
using System.Collections;
using Study;

namespace CSharpLearning
{
    public class Program
    {
        //=====USE of Employee.cs=====
        //---1. Differences between property and field---
        //      -----default get and set in property;
        //      -----correlation between field and property.
        //---2. static field in class and static method---
        //      -----access by class name; 
        //      -----static method only contains static field;
        //---3. change default value of constructor.
        public static void Main()
        {
            Employee employee1 = new Employee("20190617","Yujue","Wang");
            Console.WriteLine(employee1.FirstName);
            Console.WriteLine(Employee.count);
            employee1.FirstName="Yujue2";
            Console.WriteLine(employee1.FirstName);

            Employee employee2 = new Employee("20190627");
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName}");

            Console.WriteLine(Employee.count);

        }
        //================================================================================
        /*
        //===== USE of CarNew.cs && EngineNew.cs =====
        //--- 1. abstrct class and method---
        //      -----abstract class can contain abstract methods;
        //      -----abstract method can only be contained in abstract class;
        //      -----abstract method have no return and must be override.
        //--- 2. delegate of functions in class---
        //      -----ignore all the class, focus on the function form.
        //      -----public delegate void OnLaunchHandler()
        //--- 3. protected is used here.
        public static void Main()
        {
            CarNew myCar = new CarNew();
            EletricEngineNew e1 = new EletricEngineNew();
            myCar.run(e1.Launch);
        }
        */

        //================================================================================
        /*
        //=====USE of MyEnumerator.cs=====
        //---1. IEnumerable<> --- Iterator generation based on yield.
        //      -----public IEnumerable<int> Number()
        //---2. yield
        //---3. foreach --- Iterator can only be accessed by foreach, with no index.
        public static void Main()
        {
            int seed = 10;
            MyEnumerator e1 = new MyEnumerator(seed);
            foreach (var number in e1.Numbers())
            {
                Console.WriteLine(number);
            }
        }
        */

        //================================================================================
        /*
        //=====USE of MathElem.cs && Calculator.cs=====
        //---1.delegate and invoke---
        //      public delegate int Calc(int x, int y);
        //      public int IntCalc(int x, int y, Calc calc)
        //          return calc.invoke(x,y);
        //---2.static function use---
        public static void Main()
        {
            int x = Calculator.IntCalc(10, 5, MathElem.Add);
            Console.WriteLine(x);

            double y = Calculator.DoubleCalc(10.0, 5.0, MathElem.Divide);
            Console.WriteLine(y);
        }
        */

        //================================================================================
        /*
        //=====USE of Car.cs && Engine.cs=====
        //---1. combination of class Engine and Car---
        //---2. inheritation from class Engine---
        //---3. override the virtual method EngineRun in class Engine.---
        //      -----public override void EngineRun()
        //      -----public virtual void EngineRun()
        //      -----ATTENTION to override and virtual in the class.
        //---4. polymorphism of class Engine---
        //      -----Car car1 = new Car( new EletricEngine() )
        //      -----NOTE the parameter in Car is Engine type; but the input can be EletricEngine/ SolarEngine/ GasEngine.
        public static void Main()
        {
            EletricEngine eletricEngine1 = new EletricEngine();
            Car myCar1 = new Car(eletricEngine1);
            
            GasEngine gasEngine1 = new GasEngine();
            Car myCar2 = new Car(gasEngine1);

            SolarEngine solarEngine1 = new SolarEngine();
            Car myCar3 = new Car(solarEngine1);
        }
        */

        //================================================================================
        /*
        //=====Use of Money.cs and Currency.cs=====
        //---1. enum---
        //---2. default value of the construction function---
        public static void Main(string[] args)
        {
            Money myMoney0 = new Money(10, Currency.USD);
            myMoney0.ShowMoney();
            Money myMoney1 = new Money(20);
            myMoney1.ShowMoney();
            Money myMoney2 = new Money();
            myMoney2.ShowMoney();
        }
        */
    }
}
