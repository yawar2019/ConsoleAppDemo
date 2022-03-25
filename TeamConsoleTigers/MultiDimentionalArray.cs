using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class MultiDimentionalArray
    {

        public static void Main()
        {
            int[,] a = new int[3, 2] { 
                                    { 1, 2 }, 
                                    { 3, 4 },
                                    { 3, 4 }
                                      };
            for (int i = 0; i < 2; i++)
            {
                for (int j=0; j < 2; j++)
                {
                    Console.Write(" "+a[i, j]);

                }
            }
            Console.WriteLine(a.Length);

            Console.ReadLine();

        }
    }
}
