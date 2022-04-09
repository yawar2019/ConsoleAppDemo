using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{

    static  class ExtensionControlTextbox
    {
        public static void TextBox(this ExtensionControlClass txt )
        {
            Console.WriteLine("TextBox is Created");
        }
    }
  static class ExtensionControlDropdown
    {
        static public void Dropdown(this ExtensionControlClass dropdown)
        {
            Console.WriteLine("Dropdown is Created");
        }
    }

    sealed class ExtensionControlClass
    {
        public static void Main()
        {
            ExtensionControlClass obj = new TeamConsoleTigers.ExtensionControlClass();
            obj.TextBox();
            obj.Dropdown();
            Console.ReadLine();
        }
    }
}

//if you want ur methods of another class should be access by another class object
//where they are not present then you can call that method by extending that method
//using Extension concept

//Eg: Dropdown(this ExtensionControlClass dropdown)
//here this keyword represent current class bind this ExtensionControl class dropdow method
//now after binding u can access dropdown method with ExtensionControl Class
//even we can extend our methods in sealed class 
