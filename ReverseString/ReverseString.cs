using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputString = null;
            string result = null;

            WriteLine("Input string to be reversed.");

            char[] inputArray = inputString.ToCharArray();

            result = rString(inputArray, 0, inputArray.Length - 1);
            WriteLine(result);

            WriteLine();
            ReadKey();


        }


        public static string rString(char[] array, int start, int end)
        {
            char temp;
            string result = null;

            while (start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
    }
}
