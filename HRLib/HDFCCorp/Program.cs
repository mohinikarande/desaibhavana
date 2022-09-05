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
            //ConFirmEmployeee confirmEmployee = new ConFirmEmployeee("Reena", "Pune", 30000, "trainee");
            //Console.WriteLine(confirmEmployee);



            //ConFirmEmployeee confirmEmployeee1 = new ConFirmEmployeee();
            //Console.WriteLine(confirmEmployeee1);



            //Trainee trainee = new Trainee("Reena", "Pune", 15, 1000);
            //Console.WriteLine(trainee);



            //Console.WriteLine(trainee.CalculateSalary());



            //Console.WriteLine(confirmEmployeee1.CalculateSalary())

         List<ConFirmEmployeee> employeeList = new List<ConFirmEmployeee>(); 
         employeeList.Add(new ConFirmEmployeee { Name = "Mohini", Address = "At post Satara", EmployeeType = "Trainee", Basic = 21000, Designation = "Sofware Developer" });
         employeeList.Add(new ConFirmEmployeee { Name = "Akshada", Address = "Pune", EmployeeType = "Developer", Basic = 25000, Designation = "Tester" });           
         List<Trainee> trainee = new List<Trainee>();
            trainee.Add(new Trainee { Name = "Soniya", Address = "Nashik", EmployeeType = "Trainee" });
            trainee.Add(new Trainee { Name = "Rima", Address = "Mumbai", EmployeeType = "Trainee" });




            do
            { 


                int number = 0; 
                int number2 = 0;
                Console.WriteLine("1. All Employees"); 
                Console.WriteLine("2. Employee which you want"); 
                Console.WriteLine(); 
                Console.WriteLine("Enter a number from above choice"); 
                int result = int.Parse(Console.ReadLine());


                if (result == 1) {
                    foreach (ConFirmEmployeee emplo in employeeList) 
                    { Console.WriteLine(emplo); } 
                    foreach (Trainee emplo in trainee) 
                    { 
                        Console.WriteLine(emplo); 
                    } 
                }
                else if (result == 2)
                {
                    Console.WriteLine("Enter a Employee Number which you want : "); 
                    number = Console.ReadLine();


                    foreach (ConFirmEmployeee emplo in employeeList) 
                    { 
                        if (emplo.Empno== number)
                        {
                            Console.WriteLine(emplo);
                            number2++;
                            break;
                        }
                    }


                    foreach (Trainee emplo1 in trainee)
                    {
                        if (emplo1.Empno == number) 
                        { 
                            Console.WriteLine(emplo1);
                            number2++; 
                            break;
                        }
                    }


                    if (number2 == 0)
                    {
                        Console.WriteLine("Employe Not Found");
                    }
                }


                Console.WriteLine(); 
                Console.WriteLine("Do you Want to Continue Press 'y' or 'n' :"); 
                 choice = Console.ReadLine();


            }
            while (choice == "y");






            Console.ReadLine();



        }
    }
}