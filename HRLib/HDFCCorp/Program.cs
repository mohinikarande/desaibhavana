using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;



namespace HRApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConFirmEmployeee confirmEmployee = new ConFirmEmployeee("Reena", "Pune", 30000, "trainee");
            Console.WriteLine(confirmEmployee);



            ConFirmEmployeee confirmEmployeee1 = new ConFirmEmployeee();
            Console.WriteLine(confirmEmployeee1);



            Trainee trainee = new Trainee("Reena", "Pune", 15, 1000);
            Console.WriteLine(trainee);



            Console.WriteLine(trainee.CalculateSalary());



            Console.WriteLine(confirmEmployeee1.CalculateSalary());



            Console.ReadLine();



        }
    }
}