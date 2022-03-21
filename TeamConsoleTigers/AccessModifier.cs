using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    internal class AccessModifier
    {
        protected internal int a = 10;
        internal void show()
        {

        }
    }

    class AccessModifier2
    {
        public static void Main()
        {
            AccessModifier obj = new AccessModifier();
            obj.a;
        }
      
    }
}

//1)private --Accessiblity of class members within same class
//2)public --Accessiblity of class member within same class of same project
//                and accessiblity another project
//3)protected--protected members either methods either variable are going to access
//                   in a child class only with child class objects
//4)internal---internal members within same class ,another class of same project
//5)protected internal ---its member are accessible in same class and outside of class
//                                of same project and in another project child class
