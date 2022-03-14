using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class MethodOverloading
    {
        //accessmodifier returntype MethodName{---------}

        public void getName()
        {
            Console.WriteLine("Hello World");
        }
        public void getName2()
        {
            Console.WriteLine("Hello World2");
        }
        public string getName3()
        {
            Console.WriteLine("Hello World2");
            return "Anil";
        }
        public static void Main() {

            MethodOverloading obj = new MethodOverloading();//creating an object
            obj.getName();
            obj.getName2();
            string StudentName = obj.getName3();
            string StudentName2 = obj.getName3();
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentName2);
            Console.ReadLine();
        }
    }
    
}
