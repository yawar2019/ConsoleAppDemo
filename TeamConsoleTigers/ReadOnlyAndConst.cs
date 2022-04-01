using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ReadOnlyAndConst
    {
        readonly int a=20;

        ReadOnlyAndConst()
        {
            a = 10;
        }
        
        public static void Main()
        {
            
            //value need to provided for const 
            ReadOnlyAndConst obj = new TeamConsoleTigers.ReadOnlyAndConst();
           

            Console.WriteLine(obj.a);

            Console.ReadLine();
        }
    }
}





//const int a = 12;

//Const is predefined keyword.
//if u declare a variable with const keyword that particular variable value will not changed
//here in const variable initialization need to be done at the time of creating
//at the time of declaring variable you need to initialize varaible also.it is Mandatory
//Constant variable by default static so even without creating an object of class directly with the class name u can access
//constant variable

//C.W(A.a);

//class ReadOnlyAndConst
//{
//    const int a = 11;
//    public static void Main()
//    {
//        //value need to provided for const 

//        Console.WriteLine(ReadOnlyAndConst.a);

//        Console.ReadLine();
//    }
//}


//Readonly

//ReadOnly is a Predefined Keyword
//if u declare a variable with readonly keyword that particular value will not change.
//initialization for variable at the time of declaration is not mandatory

//initialization can be done normally assigning value to variable at the time declarationor by using Constructor