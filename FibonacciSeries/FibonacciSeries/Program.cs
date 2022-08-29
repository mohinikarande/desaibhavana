using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FibonaccySeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 1;

            while (num1 <= 100)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(num2);
            }
            Console.ReadLine();
        }
    }
}