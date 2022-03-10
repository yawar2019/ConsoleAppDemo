using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ForeachExample
    {
        public static void Main()
        {

            string[] Students = {"Surendar","Asha","Rakshita" }; 

            foreach (string item in Students)//1,2,3,4,5
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();  
        }
    }
}
