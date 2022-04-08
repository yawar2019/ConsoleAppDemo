using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    //set of Constant group of value which is give n as list to used in our app
    // it default   value is 0
    //if we want to change or  we can reinitialize value easily  
    // it can be defined under namespace and class recomendation is use in undernamespace
     
    enum subjects
    {
        English = 21,
        Hindi = 23,
        Telgue
    }

    class EnumerationExample
    {
       
        public static void Main()
        {
            Console.BackgroundColor =ConsoleColor.Magenta;
            subjects sub =subjects.English;
            int subvalue = (int)subjects.English;
            Console.WriteLine(sub+","+subvalue);
            Console.ReadLine();
        }
    }
}
