using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ConstructorExample
    {
        int a;//class variable and globalvariable  ,default value for integer is 0

        //public ConstructorExample()
        //{
        //}
        public ConstructorExample():this(2)
        {
            Console.WriteLine("Default Constructor");
        }
        public ConstructorExample(int a)
        {
            this.a = a;
            display();
        }

        public void display()
        {
            Console.WriteLine(a);
        }

        public static void Main()
        {
            ConstructorExample obj1 = new ConstructorExample();

            
            Console.ReadLine();
        }
    }
}
//constructor are special methods because constructor name and class name need to be same
//constructors will not have any return type where as ur methods will have return types
//constructor will not retur any value wheres as methods will return a value
//constructor are called automatically  where as methods we need to called explicily by creating an object
//Constructor is use to allocate memory for variable and method or logic at the time of creating an object
//constructor are use called first befor any method called
//constructor are there if u define or if dont define without constructor u cannot run ur application
