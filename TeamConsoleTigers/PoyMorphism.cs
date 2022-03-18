using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class PoyMorphism
    {
        public void Message()
        {
            Console.WriteLine("Hello World");
        }

        public string Message(int a)
        {
            Console.WriteLine(" a value is " + a);
            return "asdf";
        }


        public void Message(int a, string b)
        {
            Console.WriteLine("a value is {0},b values is {1}", a, b);
        }

        public void Message(string a, int b)
        {
            Console.WriteLine("a value is {0},b values is {1}", a, b);
        }
     
    }
    class PoyMorphism2
    {
        public static void Main()
        {
            PoyMorphism obj = new PoyMorphism();
            obj.Message();
            string result = obj.Message(1);
            obj.Message(1, "hello");
            obj.Message("hello", 1);
            Console.ReadLine();
        }
    }
}

//Method Overloading and Method Overriding and Method hidding

    //1:Method Overriding
   // it is a process where you redefine ur parent class method inside child class method is called
   //  as Method Overriding
   //your parent class method name and child class method name need to be exactly same