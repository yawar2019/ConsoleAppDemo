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
        public  void Display()
        {
            Console.WriteLine("parent class display method is called");
        }

        public  void Display2()
        {
            Console.WriteLine("parent class display2 method is called");
        }

    }
    class MethodOverridingExample2: MethodOverridingExample
    {
        public new void Display()
        {
            Console.WriteLine("Child class display method is called");
        }
        public new void Display2()
        {
            Console.WriteLine("Child class display2 method is called");
        }
        public static void Main()
        {
            MethodOverridingExample m1 = new MethodOverridingExample2();
            m1.Display();
            m1.Display2();
            MethodOverridingExample2 m2 = new MethodOverridingExample2();
            m2.Display();
            m2.Display2();
            Console.ReadLine();
        }
    }
}
//To Implement Method Overriding Parent Class must need to have Virtual keyword which will give child class
//to reimplement method inside child class .and Child class will override by using overrid keyword
//If ur parent class method is virtual and child class is overriding your parent class method 
//and creating parent class variable and pointing parent class variable to child class memory then it will called
//child class methods
//2)if ur creating parent class variable and pointing to child class variable then 
// it will called parent class method if your doing method hiding or your child class method is
//having new keyword before method name.
//methodoverriding is also called runtime polymorphism
//method overloading can be called compile time polymorphism.

//what is early binding method and late binding method?
//Method overloading orCompile time bidning  is Early binding method
//Method overridingis Late Binding method. 

