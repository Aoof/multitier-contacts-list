using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MultiTierContactList_Project.BLL
{
    internal class Validator
    {
        public static int ValidateContactId(int contactId)
        {
            if (contactId <= 0)
            {
                throw new Exception("Contact ID must be a positive integer.");
            }
            return contactId;
        }

        public static string ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty.");
            }

            return name;
        }


        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || email.Contains(' '))
            {
                throw new Exception("Email cannot be empty or contain spaces.");
            }

            // Email regex explanation:
            // ^ asserts position at start of the string
            // [^@\s]+ matches one or more characters that are not '@' or whitespace
            // @ matches the '@' character
            // [^@\s]+ matches one or more characters that are not '@' or whitespace
            // \. matches the '.' character
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                throw new Exception("Email format is invalid.");
            }

            return email;
        }
    }
}
