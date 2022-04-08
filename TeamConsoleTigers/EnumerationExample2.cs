using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConsoleTigers
{
    enum PrintOption
    {
        excel,
        pdf,
        word
    }
    class EnumerationExample2
    {
        public static void Main()
        {
            PrintOption print = PrintOption.excel;
            switch (print)
            {
                case PrintOption.excel:
                    Console.WriteLine("excel file is printed ");
                    break;
                case PrintOption.pdf:
                    Console.WriteLine("pdf file is printed ");
                    break;
                case PrintOption.word:
                    Console.WriteLine("word file is printed ");
                    break;
                default:
                    Console.WriteLine("No file to Print");
                    break;
            }
            Console.ReadLine();
        }
    }
}


//enum represent group of constant values which cannot be changed

//To Create Enum you need to use Enum Key Word

//enum subjects
//{
//    English,
//    Hindi,
//    Telgue


//}


//subjects sub = subjects.English;
//Console,WriteLine(sub);


//Wap to print file in excel,pdf, word this option need to be show for printing
//by using switch case



