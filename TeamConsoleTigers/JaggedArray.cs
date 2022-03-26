using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class JaggedArray
    {
        public static void Main()
        {
            string[][] Qalificationarr = new string[3][];
            Qalificationarr[0] = new string[3] {"SSC","Inter","Btech" };
            Qalificationarr[1] = new string[2] {"BCOM","MBA" };
            Qalificationarr[2] = new string[1] {"MBBS"};


            for (int i = 0; i < Qalificationarr.Length; i++)
            {
                for (int j = 0; j < Qalificationarr[i].Length; j++)
                {
                    Console.WriteLine("Qalifications:"+ Qalificationarr[i][j]+"");
                }

                Console.WriteLine();
            }

        }
    }
}
