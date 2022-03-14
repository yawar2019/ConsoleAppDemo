using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class Doctor
    {
        public string PatientName()
        {
            Console.WriteLine("Enter Patient Name");
            string Name = Console.ReadLine();
            return Name;
        }

        public int PatientAge(int age) //int age is called parameter
        {
            return age;
        }

        public static void Main()
        {
            Doctor d = new Doctor();
            string s = d.PatientName();
            Console.WriteLine("Enter Patient Age");
            int _ptage = Convert.ToInt32(Console.ReadLine());
            int age = d.PatientAge(_ptage);//method with parameter
            Console.WriteLine(s);
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}

//2 Methods with 2 parameter return as aresult with if else condition and atleas one lopping construct  