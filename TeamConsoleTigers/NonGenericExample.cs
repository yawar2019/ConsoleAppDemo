using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    class NonGenericExample
    {
        public static void Main()
        {
            //int[] a = new int[7];
            //a[7] = 1;
            // Console.WriteLine(a[7]);

            //ArrayList al = new ArrayList();
            //al.Add(10);
            //al.Add("Hello world");
            //al.Add(10.345);
            //al.Add(40.345);
            //al.Add(50.345);
            //al.Remove(10.345);
            //al.RemoveAt(1);
            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al[0]);

            //foreach (object o in al)
            //{
            //    Console.WriteLine(o);
            //}


            //hashtable usedmto storethe data in the form of key and value
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Sahil");
            //ht.Add(2, "jawahar");
            //ht.Add(3, "minu");

            //Console.WriteLine(ht[1]);//ht[1] 1 is key through which ir getting sahil name value

            //foreach (DictionaryEntry t in ht)
            //{
            //    Console.WriteLine(t.Key+","+t.Value);
            //}


            //SortedList st = new SortedList();
            //st.Add("z", "zebra");
            //st.Add("a", "ant");
            //st.Add("c", "cat");

            //foreach (DictionaryEntry item in st)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //stack we store the data in the form of lifo

            //Stack st = new Stack();
            //st.Push(12);
            //st.Push(22);
            //st.Push(32);

            ////

            //foreach (object item in st)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue que = new Queue();//FIFO
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Dequeue();

            ////que.Dequeue();//it  remove value from top

            //foreach (object item in que)
            //{
            //    Console.WriteLine(item);
            //}

            //List<EmployeeModel> list = new List<EmployeeModel>();

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.FirstName = "t";


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 2;
            emp2.FirstName = "k";


            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.FirstName = "r";

            //list.Add(emp1);
            //list.Add(emp2);
            //list.Add(emp3);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.EmpId+","+item.FirstName);
            //}

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "Anu");
            //dict.Add(2, "kanu");
            //dict.Add(3, "tanu");

            //Console.WriteLine(dict[3]);//to read any information from dictionary dict[key] 
            //                           //eg:dict[3] 3 here is key
            //foreach  (KeyValuePair<int,string> item in dict)
            //{
            //    Console.WriteLine(item.Key + "," + item.Value);
            //}                           

            //Dictionary<string, EmployeeModel> dict = new Dictionary<string, EmployeeModel>();
            //dict.Add("FirstEmployee", emp1);
            //dict.Add("SecondEmployee", emp2);
            //dict.Add("ThirdEmployee", emp3);

            //foreach (KeyValuePair<string,EmployeeModel> item in dict)
            //{
            //    Console.WriteLine(item.Key+","+item.Value.EmpId+","+item.Value.FirstName);
            //}
            //it store value and display value based on ascending order 
            // SortedList<string, string> s1 = new SortedList<string, string>();
            //s1.Add("sarita", "Btech");
            //s1.Add("Farheen", "Biotech");
            //s1.Add("Radha", "MCA");


            //SortedList<int, string> s1 = new SortedList<int, string>();
            //s1.Add(1, "Btech");
            //s1.Add(21, "Biotech");
            //s1.Add(13, "MCA");

            //foreach (KeyValuePair<int, string> item in s1)
            //{
            //    Console.WriteLine(item.Key+":"+item.Value);
            //}

            //whatever item is store last will be printed first o/p 21,12,13 ,lifo
            //Stack<int> lst = new Stack<int>();
            //lst.Push(13);
            //lst.Push(12);
            //lst.Push(21);

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //fifo
            //Queue<int> lst = new Queue<int>();
            //lst.Enqueue(12);
            //lst.Enqueue(2);
            //lst.Enqueue(42);

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadLine();

        }
    }
}
