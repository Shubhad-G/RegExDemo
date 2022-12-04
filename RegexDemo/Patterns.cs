using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";
        public static string REGEX_FIRSTNAME = "^[A-Z]{3,}$";
        public bool ValidatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode,REGEX_PINCODE);
        }
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName,REGEX_FIRSTNAME);
        }
    }
}
