using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class StringAndStringBuilder
    {
        public static void Main()
        {
            string a = "Welcome";
            a = "To USA";
            StringBuilder str = new StringBuilder();
            str.Append("Hello");
            //str.Append("Hello To");
            //str.Append("Hello To All of u ");

            str.Replace("Hello", "Hi", 0, 5);
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}


//string immutable 
//once value is assigned in a string variable that value will be changed or replace
//To Assing New value it will create new object and assign value to new object
    
    
    //StringBuilder is Mutable object
    ///you can replace value in stringbuilder class
    ///to replace values we can use Replace method keyword
///if u overide value then it use same memory object instead of new

 