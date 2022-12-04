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
        public static string REGEX_EMAIL = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public static string REGEX_PHONE = "^[0-9]{10}$";
        public bool ValidatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode,REGEX_PINCODE);
        }
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName,REGEX_FIRSTNAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email,REGEX_EMAIL);
        }
        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone,REGEX_PHONE);
        }
        public void Validate(bool isMatch)
        {
            if (isMatch)
                Console.WriteLine("is validated");
            else
                Console.WriteLine("not validated");
        }
    }
}
