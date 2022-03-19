using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class inheritance1
    {
       public  inheritance1()
        {
            Console.WriteLine("Inheritance1 constructor is called");

        }
        public void display() {
            Console.WriteLine("Inheritance1 is called");
        }

    }
    class inheritance2: inheritance1
    {
        public  inheritance2()
        {
            Console.WriteLine("Inheritance2 constructor is called");

        }
        public void display()
        {
            base.display();
            Console.WriteLine("Inheritance2 is called");
        }
    }
    class inheritance3: inheritance2
    {
        public  inheritance3()
        {
            Console.WriteLine("Inheritance3 constructor is called");

        }
        public  void display()
        {
            Console.WriteLine("Inheritance3 is called");
        }
    }
    class inheritance4
    {
        public  inheritance4()
        {
            Console.WriteLine("Inheritance4 constructor is called");

        }
        public static void Main()
        {
            inheritance2 obj = new inheritance3();
            obj.display();
            Console.ReadLine();
        }
    }
}
