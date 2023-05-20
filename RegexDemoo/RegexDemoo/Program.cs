using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Registration registration = new Registration();
            Console.Write("Enter Your First Name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(registration.FirstName(FirstName));

            Console.WriteLine("Enter Your First Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(registration.LastName(LastName));

            Console.WriteLine("Enter Your Email ID");
            string Email = Console.ReadLine();
            Console.WriteLine(registration.Email(Email));

            Console.WriteLine("Enter Your Phone Number");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine(registration.PhoneNumber(PhoneNumber));

            Console.WriteLine("Enter your Password one");
            string Password_one = Console.ReadLine();
            Console.WriteLine(registration.Password_one(Password_one));

            Console.WriteLine("Enter your Password Two");
            string password_two = Console.ReadLine();
            Console.WriteLine(registration.Password_Two(password_two));

            Console.WriteLine("Enter Your Password");
            string password3 = Console.ReadLine();
            Console.WriteLine(registration.Password_Three(password3));

            Console.WriteLine("Enter Your Password");
            string password4 = Console.ReadLine();
            Console.WriteLine(registration.Password_Four(password4));

            registration.Test();



            Console.ReadLine();
        }
    }
}
