using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class MethodOverridingExample
    {
        public int a;
        public virtual void Display()
        {
            Console.WriteLine("parent class display method is called");
        }

        public void Display2()
        {
            Console.WriteLine("parent class display2 method is called");
        }

    }
    class MethodOverridingExample2: MethodOverridingExample
    {
        public override void Display()
        {
            Console.WriteLine("Child class display method is called");
        }
        public new void Display2()
        {
            Console.WriteLine("Child class display2 method is called");
        }
        public static void Main()
        {
            MethodOverridingExample2 obj = new MethodOverridingExample2();
            obj.Display();
            obj.Display2();
            Console.ReadLine();
        }
    }
}
//To Implement Method Overriding Parent Class must need to have Virtual keyword which will give child class
//to reimplement method inside child class .and Child class will override by using overrid keyword