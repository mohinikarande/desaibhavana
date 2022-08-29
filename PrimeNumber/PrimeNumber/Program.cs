using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int i, j;

            Console.WriteLine("Prime Between 1 to 100 are : ");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
