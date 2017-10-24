using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneLineInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string str;

            Console.WriteLine("정수들을 한줄에 입력하세요");
            string[] token;

            double[] tab = new double[10];
            double sum = 0, avg;

            str = null;
            str = Console.ReadLine();

            token = str.Split(' ');
            for (i = 0; i < token.Length; i++)
                token[i].Trim();
            for (i = 0; i < token.Length; i++)
                tab[i] = Convert.ToDouble(token[i]);

            for (i = 0, sum = 0; i < token.Length; i++)
                sum += tab[i];

            avg = sum / token.Length;
            Console.WriteLine("total = {0}, avg = {1}", sum, avg);
        }
    }
}
