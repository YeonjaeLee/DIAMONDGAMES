using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("출력할 구구단 : ");
            number = int.Parse(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2,2}", number, i, number * i);
            }
        }
    }
}
