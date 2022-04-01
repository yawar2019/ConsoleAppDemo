using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    abstract class AbstractClassExample
    {
        //public abstract void Method1();//abstract Method
        public void Method2() {

            //concrete method 

            Console.WriteLine("Method 2 is Called");
        }


    }

    class AbstractClassExample2 : AbstractClassExample
    {
        public   void Method1()
        {
            Console.WriteLine("Method 1 is Called");
            
        }
        public static void Main()
        {
            AbstractClassExample2 obj = new AbstractClassExample2();
            obj.Method1();
            Console.ReadLine();

        }
    }
}


//hiding of unwanted information and showing important information is called as abstraction

    //eg car wheels,breaks are shown to us which need where as piston,head ,engine is hidden as it isun wanted information

    //abstraction can be implemented by two ways 

    //1) Abstract Class
    //2) interfaces

    //a class which is declare with keyword abstract so that class is called abstract class
    //abstract class contain 2 types of method
    //abstract method ,Non Abstract Method
    //the method which does'nt have body just declaration only present so that is called as abstract method
    //All Methods which have body is called as non abstract method or concrete
    //we cannot create object of abstract class as it is an incomplete class

