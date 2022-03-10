using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class ForeachExample2
    {
        public static void Main()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.FirstName = "Kalpana";


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1;
            obj1.FirstName = "kiran";


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 2;
            obj2.FirstName = "Rajesh";


            List<EmployeeModel> listObj = new List<EmployeeModel>();

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            foreach (var item in listObj)
            {
                Console.Write(item.EmpId+"-");
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }
}
