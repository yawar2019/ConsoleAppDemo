using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Books
    {
        protected internal int BookId;
    }
    public class Books1
    {
        public void show()
        {
            Books obj = new Books();
            obj.BookId=10;
        }
    }
}
