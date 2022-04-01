using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    interface Interface1
    {
      void Test();
    }

    interface Interface2
    {
        void Test();
    }
    public class Test3
    {

    }

    class InterfaceClassExample : Test3,Interface1, Interface2
    {
         void Interface1.Test()
        {
            Console.WriteLine("testing test1");
        }

        void Interface2.Test()
        {
            Console.WriteLine("testing test2");
        }
        public static void Main()
        {

            Interface1 i1 = new InterfaceClassExample();
            i1.Test();
            Interface2 i2 = new InterfaceClassExample();
            i2.Test();
            Console.ReadLine();
        }
    }
}
