using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class PropertiesExample1
    {
        private int a;
        public string EmpName { get; set; }
        public int Emp
        {
            set
            {
                if (value > 10)
                {
                    a = value;
                }
                else
                {
                    a = 100;
                }
            }

            get { return a * a; }
        }


    }
    class PropertiesExample2
    {
        public static void Main()
        {
            PropertiesExample1 obj = new PropertiesExample1();
            obj.Emp = 11;
            obj.EmpName = "test";
            Console.WriteLine(obj.EmpName);
            Console.ReadLine();
        }
    }
}
