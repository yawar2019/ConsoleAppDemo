using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Datatype
    {
        public static void Main()
        {
            int EmpId=1211;
            string EmpName = "James";
            //float Salary=6700.987234567F;
            //double Salary=6700.987234434345345567;
            decimal Salary =6700.12345678901234567890M;
            char Active='y';

            Console.WriteLine("EmpId "+ EmpId);
            Console.WriteLine("EmpName "+EmpName);
            Console.WriteLine("EmpSalary "+Salary);
            Console.WriteLine("Active "+Active);
            Console.ReadLine();

        }
    }

    class PassingDynamicValue
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter your Id");
            int id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter your Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Please Enter your Salary");
            //float Salary = Convert.ToSingle(Console.ReadLine());
           // double Salary = Convert.ToDouble(Console.ReadLine());
            decimal Salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter your status");
            char status = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Employee id :"+id+" \nEmployee Name:"+Name+"\nEmpSalary:"+Salary+"\nStatus:"+status);


           
            Console.ReadLine();

        }
    }
}
