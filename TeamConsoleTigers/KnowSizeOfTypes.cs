using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class KnowSizeOfTypes
    {
        public static void Main()
        {
            char a = '2';
            Console.WriteLine(a);// to know max value Integer can hold
            Console.WriteLine(long.MinValue);//to know min value integer can hold
            Console.WriteLine(sizeof(long));//int terms of bytes you need to sizeOf
            Console.ReadLine();
        }
    }
}
