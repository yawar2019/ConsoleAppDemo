using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class MethodOverloading3
    {
        public string EmployeeName()
        {
            Console.WriteLine("Pls enter EmployeeName");
            string Name = Console.ReadLine();
            return Name;
        }

        public int EmployeeId()
        {
            Console.WriteLine("Pls enter EmpId");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            return EmpId;
        }

        public void GetEmployeeDetails()
        {
            MethodOverloading3 obj = new MethodOverloading3();
            int EmployeeId = obj.EmployeeId();
            string  EmployeeName = obj.EmployeeName();

            Console.WriteLine(EmployeeId + "," + EmployeeName);
        }


        public static void Main()
        {
            MethodOverloading3 obj = new MethodOverloading3();
            obj.GetEmployeeDetails();

            Console.ReadLine();
        }
    }
}
