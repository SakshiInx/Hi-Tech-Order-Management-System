using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace Hi_Tech_Order_Management_System.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input, int size)
        {
            if (!Regex.IsMatch(input, @"^\d{" + size + "}$"))
            {
                return false;
            }

            return true;
        }


        public static bool IsValidName(string input)
        {
            if (input == "")
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    return false;
                }

            }

            return true;
        }

        public static bool IsEmpty(string input)
        {
            if (input == "")
            {
                return false;
            }

            return true;
        }
    }
}

