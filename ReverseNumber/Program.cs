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
            char[] a = { 'a', 'b', 'c', 'd' };

            Console.WriteLine("Before reverse:");
       
            for (int o = 0; o < a.Length; o++)
            {
                Console.Write(a[o] + "\t");
            }

            int i = 0;
            int j = a.Length - 1;
            char temp;

            while(i < j)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;

                i++;
                j--;
             }

            Console.WriteLine();
            Console.WriteLine("After reverse:");

            for (int m = 0; m < a.Length; m++)
            {
                Console.Write(a[m] + "\t");
            }

            Console.ReadKey();
        }
    }
}
