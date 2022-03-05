using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class SwitchCaseExample
    {
        public static void Main()
        {
            Console.WriteLine("Anil Five Star Hotel");
            Console.WriteLine("*****");
            Console.WriteLine("Press 1:Idly\n 2:Doosa\n 3:Wada\n 4:Puri");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("50 days old idly");
                    break;
                case 2:
                    Console.WriteLine("Doosa with fungus");
                    break;
                case 3:
                    Console.WriteLine("black wada with Mirchi");
                    break;
                case 4:
                    Console.WriteLine("Amresh puri");
                    break;

                default:
                    Console.WriteLine("Rs 1000 bill");
                    break;
            }

            Console.ReadLine();

        }

    }
}
