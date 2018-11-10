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

            WriteLine("Input string to be reversed. Type \"exit\" to exit program." + "\n");
            

            while (inputString != "exit")
            {
                Write("{0,8}", "Input : ");
                inputString = ReadLine();
                char[] inputArray = inputString.ToCharArray();
                result = rString(inputArray, 0, inputArray.Length - 1);
                WriteLine("Result: " + result);
                WriteLine();
            }
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

            foreach (char letter in array)
            {
                result += letter;
            }

            return result;
        }
    }
}
