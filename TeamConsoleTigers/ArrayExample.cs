using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ArrayExample
    {
        //public static void Main()
        //{
        //    int[] a = { 1, 2, 4, 5, 6, 7 };
        //    Console.WriteLine(a[2]);
        //    Console.ReadLine();
        //}

        //public static void Main()
        //{
        //    int[] a = new int[2];
        //    a[0] = 1;
        //    a[1] = 2;
        //    Console.WriteLine(a[1]);
        //    Console.ReadLine();
        //}


        //public static void Main()
        //{
        //    int[] a = new int[2] {1,2 };
        //    a[0] = 1;
        //    a[1] = 2;
        //    Console.WriteLine(a[1]);
        //    Console.ReadLine();
        //}

        //public static void Main()
        //{

        //    int[] studnetsId = { 1, 2, 3 };

        //    foreach (var item in studnetsId)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        public static void Main()
        {
            // int[] studnetsId = { 1, 2, 3 };
            //string[] Name = { "Anil", "Sarita", "Kavita" };

            int[] studnetsId = new int[3];
            string[] Name = new string[3];

            Console.WriteLine(" enter three EmployeesId");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Employee id");
                studnetsId[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                Name[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Id is {0}",studnetsId[i]);
                Console.WriteLine("Name is {0}",Name[i]);
            }


            Console.ReadLine();
        }

    }
}
