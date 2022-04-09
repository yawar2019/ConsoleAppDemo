using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    static class StaticClassExample
    {
         static int a = 10;
       
        static StaticClassExample()
        {
            Console.WriteLine("Static Constructor is Called");
        }


        public static void show()
        {
            Console.WriteLine(a);
        }

        public static void Main()
        {
            StaticClassExample.show();
            Console.ReadLine();
        }
    }

     
}

//you can have only static member in static class
//there will be only one one constructor for static 
//static class doe'snt required object creation directly with class name u can call
//parameter is not not allowed in static constructor

