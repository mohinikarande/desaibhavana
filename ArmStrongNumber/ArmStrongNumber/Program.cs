using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            for (int i = 1; i <= 1000; i++)

            {

                num1 = i / 100;

                num2 = (i - num1 * 100) / 10;

                num3 = (i - num1 * 100 - num2 * 10);

                num4 = num1 * num1 * num1 + num2 * num2 * num2 + num3 * num3 * num3;

                if (i == num4)

                {

                    System.Console.WriteLine("{0}", i);

                }

            }

            Console.Read();
        }
    }
}
