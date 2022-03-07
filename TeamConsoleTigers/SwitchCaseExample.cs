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

    class SwitchCaseExample2
    {
        public static void Main()
        {
           
            Console.WriteLine("Please select 1)cloths\n 2)watch");
            char Choice = Convert.ToChar(Console.ReadLine());
            switch (Choice)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowels is Entered");
                    break;
                

                default:
                    Console.WriteLine("Consonent Entered");
                    break;
            }

            Console.ReadLine();

        }

    }

    class SwitchCaseExample3
    {
        public static void Main()
        {

            Console.WriteLine("Please select 1)cloths\n 2)watch");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Please select 1)shirt\n2)jeans\n3)shoes");
                    int Choice2 = Convert.ToInt32(Console.ReadLine());

                    switch(Choice2)
                    {
                        case 1:
                            Console.WriteLine("shirt of 2000 selected");
                            break;
                        case 2:
                            Console.WriteLine("jeans of 2000 selected");

                            break;
                        case 3:
                            Console.WriteLine("shoes of 2000 selected");

                            break;
                        default:
                            Console.WriteLine("Np item is selected");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Please select 1)armani\n2)titan\n3)clock");
                    int Choice3= Convert.ToInt32(Console.ReadLine());

                    switch (Choice3)
                    {
                        case 1:
                            Console.WriteLine("armani watch of 2000 selected");
                            break;
                        case 2:
                            Console.WriteLine("titan watch of 2000 selected");

                            break;
                        case 3:
                            Console.WriteLine("clock watch of 2000 selected");

                            break;
                        default:
                            Console.WriteLine("No watch selected item is selected");
                            break;
                    }

                    break;


                default:
                    Console.WriteLine("no item is selected");
                    break;
            }

            Console.ReadLine();

        }

    }

    class SwitchCaseExample4
    {
        public static void Main()
        {

            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press + for Add\n- for Sub\n* for Mul\n \\ for div\n ");
            char Choice = Convert.ToChar(Console.ReadLine());
            switch (Choice)
            {
                case '+':
                    Console.WriteLine(a+b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
               
                default:
                    Console.WriteLine("no Options is selected");
                    break;
            }

            Console.ReadLine();

        }

    }
}
