﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class LoopingConstraint
    {
        public static void Main()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }

    class LoopingConstraint2
    {
        public static void Main()
        {
            Console.WriteLine("Enter table No");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", num,i,num*i);

            }
            Console.ReadLine();
        }
    }

    class LoopingConstraint3
    {
        public static void Main()
        {
            Console.WriteLine("sum of 10 numbers");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }

    class LoopingConstraint45
    {
        public static void Main()
        {
            Console.WriteLine("sum of 10 numbers");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }

    class LoopingConstraint5
    {
        public static void Main()
        {
            Console.WriteLine("How many employees details you want?");


            Console.ReadLine();
        }
    }

}
