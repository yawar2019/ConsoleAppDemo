using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;
namespace ServerSidePRoject
{
    class Program:Books
    {
        int a;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.BookId = 11; //protected:same and another project. internal for same project
        }
    }
}
