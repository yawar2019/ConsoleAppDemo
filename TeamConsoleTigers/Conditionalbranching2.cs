using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Conditionalbranching2
    {
        public static void Main()
        {
            int a = 70, b=70,c= 70;

            //if block example
            //if(a>b)
            //{
            //    Console.WriteLine("a is greater");
            //}

            //if-else
            //if (a > b)
            //{
            //        Console.WriteLine("a is greater");

            //}
            //else
            //{
            //        Console.WriteLine("b is greater");

            //}

            //if-elseif-else
            //if (a > b)
            //{
            //    Console.WriteLine("a is greater");

            //}
            //else if(b>a)
            //{
            //    Console.WriteLine("b is greater");

            //}
            //else
            //{
            //    Console.WriteLine("both are equal");

            //}

            //nested if

            if(a>b && b>c)
            {
                if(a>c)
                {
                    Console.WriteLine("a is greatest");
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("b is greatest");
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("c is greatest");
                }
            }
            if(a==b && b==c)
            {
                Console.WriteLine("All are equal");
            }
            else
            {

            }

            Console.ReadLine();
        }
    }
}
