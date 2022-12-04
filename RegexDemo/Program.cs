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
            Console.WriteLine("Enter user details");
            Console.WriteLine("enter the first name");
            string firstName = Console.ReadLine();
            bool isMatchFname = patterns.ValidateFirstName(firstName);
            patterns.Validate(isMatchFname);

            Console.WriteLine("enter the last name");
            string lastName = Console.ReadLine();
            bool isMatchLname = patterns.ValidateFirstName(lastName);
            patterns.Validate(isMatchLname);
            Console.ReadLine(); 
        }
    }
}
