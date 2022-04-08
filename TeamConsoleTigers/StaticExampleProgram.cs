using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class StaticExampleProgram
    {
        public static int a = 10; 

        public void testStaticVariable()
        {
            Console.WriteLine(a);
            a++;

        }
        public static void Main()
        {
            StaticExampleProgram obj = new StaticExampleProgram();
            obj.testStaticVariable();

            StaticExampleProgram obj1 = new StaticExampleProgram();
            obj1.testStaticVariable();

            Console.WriteLine(StaticExampleProgram.a);

            Console.ReadLine();    
        }
    }
}


//static varaibale is declared with the help of static keyword
//when u declare as a static variable , then it will share single copy of variable among
//all the objects
//static variable are access with the name of class 
//they do not required object to access
//declare static variable either in in class scope or inside static block
//which is going to called first in ur program main method or static block
//static block is going to be called before main method 