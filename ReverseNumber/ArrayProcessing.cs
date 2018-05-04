using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public class ArrayProcessing
    {
        private char[] Array;

        public ArrayProcessing(char[] targetArray)
        {
            Array = targetArray;
        } 
        
        public void Print()
        {
            Console.WriteLine("Before Reverse:");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + "\t");
            }      
        }

        public void Reverse()
        {
            int firstIndex = 0;
            int lastIndex = Array.Length - 1;
            char temp;

            while (firstIndex < lastIndex)
            {
                temp = Array[firstIndex];
                Array[firstIndex] = Array[lastIndex];
                Array[lastIndex] = temp;

                firstIndex++;
                lastIndex--;
            }

            Console.WriteLine();
            Console.WriteLine("After Reverse:");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + "\t");
            }
        }
    }
}