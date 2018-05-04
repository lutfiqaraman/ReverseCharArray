using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayofchars = { 'a', 'b', 'c', 'd' };

            ArrayProcessing targetArray = new ArrayProcessing(arrayofchars);

            targetArray.Print();
            targetArray.Reverse();

            Console.ReadKey();
        }
    }
}