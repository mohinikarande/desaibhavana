using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVerifyLib
{
    public class Password
    {
        private string letter;

        public string Letter
        {
            get { return letter; }
            set { letter = value; }
        }

        private string specialcharacter;

        public string SpecialCharacter
        {
            get { return specialcharacter; }
            set { specialcharacter = value; }
        }

        private int digit;

        public int Digit
        {
            get { return digit; }
            set { digit = value; }
        }

        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }


            public  bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };   
                if (passWord.IndexOfAny(special) == -1) return false;
            }
           
            return true;
        }

        public override string ToString()
        {
            return String.Format($" Letter : {letter} SpecialCharacter : {specialcharacter} Digit : {digit} Length: {length}");

        }
    }
}
