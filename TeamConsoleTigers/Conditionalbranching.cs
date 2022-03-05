using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Conditionalbranching
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Election Booth");
            Console.WriteLine("Please Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Elligible for Voting");
                Console.WriteLine("go for Voting");
            }
            else
                Console.WriteLine("Not Elligible for Voting");
            Console.ReadLine();
        }
    }
}
