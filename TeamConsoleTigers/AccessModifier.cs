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


//In Our.netFramework we have two types of Assemblies
//Private Assemblies
//.exe type which u can click and execute


//Shared Assemblies
//.dll type which u can run or exute it you need supprt of.exe project you can execute your .dll code



//what is Assemblies?
//Assemblies are build code which can be either in the for of.dll or exe type


//exe full form is executable file
//dll full form is data link library

//you cannot share your private assembly code to another project
//you can share Shared Assembly code with other projects


//if you want reusability of code create Shared Assembly project

//How to Create Shared Assembly and Private Assembly Project

//Shared Assembly project will class library type project
//Private Assembly Project will beyou console application type project