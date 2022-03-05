using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Mobile
    {
        int price;//declaration of variable
        string Name; //declaration variable

       void Calling()
        {
            Console.WriteLine("SomeOne Calling");

        }

        void Ringing()
        {
            Console.WriteLine("your Phone is Ringing");
        }


        public static void Main()//Entry point for Executing 
        {
            Mobile samsungObj = new Mobile();
            samsungObj.Name = "Samsung New Model";
            samsungObj.price = 290000;
            Console.WriteLine("Name of Mobile:"+samsungObj.Name+", Price of Mobile "+samsungObj.price);
            samsungObj.Calling();//call methods
            samsungObj.Ringing();

            Mobile jioMobileObj = new Mobile();
            jioMobileObj.Name = "Jio New Model";
            jioMobileObj.price = 2000;
            Console.WriteLine("Name of Mobile:" + jioMobileObj.Name + ", Price of Mobile " + jioMobileObj.price);
            jioMobileObj.Calling();//call methods
            jioMobileObj.Ringing();


           




            Console.ReadLine();


        }


    }
}
