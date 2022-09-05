using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification
{
    public class PasswordException : Exception
    {
        public PasswordException(string msg) : base(msg)
        {

        }
    }
}
