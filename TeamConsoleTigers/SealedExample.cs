using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
   public sealed class SealedExample
    {
        public void show()
        {
            Console.WriteLine("Show Method is Called");
        }
    }
    public class SealedExample2
    {

    }
}



//so if you want to make any class locked for inheriting in another class
//make that class sealed class

//we cannot inherit any membe of that class which class is sealed
//overriding not possible for sealed class

//by declaring sealed keyword you can stop that class to be inherited
//sealed means locked.