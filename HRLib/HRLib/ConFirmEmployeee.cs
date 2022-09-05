using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public  class ConFirmEmployeee : Employee
    {
        private double basic;

        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public ConFirmEmployeee()
        {
            Basic = 30000;
            Designation = "Trinee";

        }

        public ConFirmEmployeee(string name, string address, double basic, string designation ) : base(name, address)
        {

           Basic=basic;
           Designation=designation;
        }

        public override string ToString()
        {
            return String.Format($" BAsic : {basic} Designation : {designation}");
        }

        public override double CalculateSalary()
        {
            double hra = 0, conv = 0, pf = 0, netSalary;

            if (basic >= 30000)
            {
                hra = basic * 0.3;
                conv = basic * 0.3;
                pf = basic *0.3;
            }
            
            else if (basic >= 20000)
            {
                hra = basic * 0.2;
                conv = basic * 0.2;
                pf = basic * 0.2;
            }

            else
            {
                hra = basic * 0.1;
                conv = basic * 0.1;
                pf = basic * 0.1;
            }

            netSalary = basic + hra + conv- pf;
            return netSalary;

        }
    }
}
