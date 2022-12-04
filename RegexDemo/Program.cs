using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine("enter the pincode");
            string pincode = Console.ReadLine();
            bool isMatch = patterns.ValidatePinCode(pincode);
            if (isMatch)
                Console.WriteLine("pincode is validated");
            else
                Console.WriteLine("pinncode is not validated");

            Console.WriteLine("enter the first name");
            string firstName = Console.ReadLine();
            bool isMatchFname = patterns.ValidateFirstName(firstName);
            if (isMatchFname)
                Console.WriteLine("first name is validated");
            else
                Console.WriteLine("first name is not validated");
            Console.ReadLine(); 
        }
    }
}
