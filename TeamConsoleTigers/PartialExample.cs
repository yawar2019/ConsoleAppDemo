using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    partial class PartialExample
    {
        public void Work1()
        {
            Console.WriteLine("Work1 Done");
        }
    }

   partial class PartialExample
    {
        public void Work2()
        {
            Console.WriteLine("Work2 Done");
        }
    }

    partial class PartialExample
    {
        public static void Main()
        {
            PartialExample obj = new PartialExample();
            obj.Work1();
            obj.Work2();
            Console.ReadLine(); 
        }
    }
}


//partial class

//A class which is defined by the keyword partial so that type of class is called
//as partial class

//if you want to make multiple people to write different code in same class simantaneosly
//it is possible with the help of partial class 