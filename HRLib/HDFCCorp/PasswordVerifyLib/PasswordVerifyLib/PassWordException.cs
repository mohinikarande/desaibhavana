using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVerifyLib
{
    public class PassWordException : Exception
    {
        public PassWordException(string msg) : base(msg)
        {

        }
    }
}
