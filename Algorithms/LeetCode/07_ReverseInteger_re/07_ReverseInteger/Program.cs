using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -123;

            Console.WriteLine( reverseInteger(x));
        }

        public static int reverseInteger(int num)
        {
            string stnum = null;
            stnum = num.ToString();

            string[] temp = stnum.Split('-');
            string result = null;

            if (temp[0].Length == stnum.Length)
            {
                result = new string(temp[0].ToCharArray().Reverse().ToArray());
            }
            else
            {
                result = "-" + new string(temp[1].ToCharArray().Reverse().ToArray());
            }
            
            return Convert.ToInt32(result);
        }
    }
}
