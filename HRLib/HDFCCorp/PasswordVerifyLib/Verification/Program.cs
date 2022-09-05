using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordVerifyLib;

namespace Verification
{
    internal class TestPassword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password :");
            string value = Console.ReadLine();
            Password password = new Password();
            Console.WriteLine(value);
            Console.WriteLine(password);
            try
            {
                bool result = password.ValidatePassword(value);
                Console.WriteLine(result);
            }
            catch (PassWordException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Password is weak . Please enter strong password");
            }
           


            Console.ReadLine();
        }
    }
}
