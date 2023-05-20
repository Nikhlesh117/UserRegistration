using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemoo
{
    public class Registration
    {
        public static string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string Regex_PhoneNumber = "[+][1-9]{1,2}[ ][0-9]{10}$";

        public const string Regex_Password_One = "^[A-Za-z0-9]{8,15}$";
        public const string Regex_Password_Two = "^[A-Z]{1}+[a-z0-9]{8,}$";
        public const string Regex_Password_Three = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string Regex_Password_Four = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool LastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        }
        public bool Email(string email)
        {
            return Regex.IsMatch((string)email, Regex_Email);
        }
        public bool PhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, Regex_PhoneNumber);
        }
        public bool Password_one(string password_one) 
        {
            return Regex.IsMatch(password_one, Regex_Password_One);
        }
        public bool Password_Two(string password_two)
        {
            return Regex.IsMatch(password_two, Regex_Password_Two);
        }
        public bool Password_Three(string password3)
        {
            return Regex.IsMatch(password3, Regex_Password_Three);
        }
        public bool Password_Four(string password4)
        {
            return Regex.IsMatch(password4, Regex_Password_Four);
        }
        public void Test()
        {
            Registration validate = new Registration();
            Console.WriteLine("A. Valid Emails");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.Email(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.Email(invalidEmails[i]));
            }
        }

    }
}
