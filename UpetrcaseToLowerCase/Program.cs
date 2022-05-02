using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpetrcaseToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a upper case Character");

            Char value = Convert.ToChar(Console.ReadLine());

         //   value = Convert.ToChar(index_number);

            Console.WriteLine("The input value is  {0} ", value);

            int unicode = value + 32;

            Char myChar = (Char)unicode;

            Console.WriteLine("The required Output is {0}",myChar);


            Console.ReadLine();

        }
    }
}
