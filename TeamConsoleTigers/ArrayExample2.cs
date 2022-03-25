using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ArrayExample2
    {
        public static void Main()
        {
            int[] id= new int[3] {1,2,3 };
            string[] Name= new string[3] {"Anil","sarita","farheen"};
            int[] Marks = new int[3] {100,150,200 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Eid {0},EName {1},ESalary {2}",id[i],Name[i],Marks[i]);
            }

            Console.ReadLine();
        }
    }
}
