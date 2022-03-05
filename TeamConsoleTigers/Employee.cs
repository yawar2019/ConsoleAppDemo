using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Employee
    {
        public static void Main()
        {
            //int a = 10,b = 20;
            //datatype variable=value;
            //Console.WriteLine(a+b);

            //string Name = "jhansi ki rani";
            //Console.WriteLine(Name);


            //int age = 21;
            //string Name = "Kavitha";
            //Console.WriteLine(Name + "-" + age);

            //int age = 21;
            //string Name = "Kavitha";
            //Console.WriteLine("My Name is :{0}, and i am from london and My age is {1}", Name,age);
            //Console.WriteLine("My age is {0}",age);

            //Console.WriteLine("Please Enter your Name?");
            //string Name = Console.ReadLine();
            //Console.WriteLine("My Name is {0}",Name);

            Console.WriteLine("addition of two numbers");
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result="+(a + b));

            Console.ReadLine();
        }
    }

    class Department
    {
        public static void Main()
        {
            Console.WriteLine("Department Name is IT");
            Console.ReadLine();
        }
    }
}
