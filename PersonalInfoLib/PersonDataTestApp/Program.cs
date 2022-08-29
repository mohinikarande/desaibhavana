using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace PersonDataTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mohini", "Karande", "mohini@email.com", Convert.ToDateTime("12/27/1999"));

            Console.WriteLine(person1);
            Console.WriteLine("Is Person is Adult" + person1.IsAdult());


            Console.ReadLine();
        }
    }
}
