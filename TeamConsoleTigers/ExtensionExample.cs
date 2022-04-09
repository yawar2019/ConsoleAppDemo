using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ExtensionExample
    {

        public void A()
        {
            Console.WriteLine("A is Called");
        }

        public void B()
        {
            Console.WriteLine("B is Called");
        }
    }

    class ExtensionExample3
    {

        public void D()
        {
            Console.WriteLine("A is Called");
        }

        public void E()
        {
            Console.WriteLine("B is Called");
        }
    }
    static class ExtensionExample2
    {

        public  static  void C(this ExtensionExample3 abc )
        {
            Console.WriteLine("C is Called");
        }

        public static void Main()
        {
            ExtensionExample obj = new ExtensionExample();
            obj.A();
            obj.B();
            ExtensionExample3 obj1 = new ExtensionExample3();

            obj1.C();
            
            Console.ReadLine();
        }
         
    }

}


//In C#