using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class WhileLoopExample
    {
        public static void Main()
        {
            int i = 1;//Initilization

            //for (; i<10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            char ch = 'Y';
            while (ch=='Y')
            {
                Console.WriteLine("Welcome to My World");
                ch = Convert.ToChar(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
