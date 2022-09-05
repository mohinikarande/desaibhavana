using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public  abstract class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int empno;

        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }





        public Employee()
        {
            Name= "Mohini";
            Address= "xyz";
        }
        public Employee(string name, string address)
        {
            Name=name;
            Address=address;

        }

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return String.Format($"Name : {name} Address : {address}");
        }
          

        private static int count;

        public static int Count
        {
            get { return count; }
        private set { 
                count = value; 
            }
        }
        


    }




}