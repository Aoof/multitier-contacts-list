using MultiTierContactList_Project.DAL;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MultiTierContactList_Project.BLL
{
    internal class Validator
    {
        public static int ValidateContactId(int contactId)
        {
            if (contactId <= 0 || contactId > 10000000)
            {
                throw new ValidationException("Contact ID must be between 1 to 7 digits long.");
            }
            return contactId;
        }

        public static string ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationException("Name cannot be empty.");
            }

            // Name regex explanation:
            // [ starts a character combination
            // a-zA-Z allows any letter
            // \s allows whitespace
            // \' allows apostrophes
            // \- allows hyphens
            // \, allows commas
            // ]+ ends the character combination
            if (Regex.IsMatch(name, @"^[a-zA-Z\s\'\-\,]+$") == false)
            {
                throw new ValidationException("Name contains invalid characters.");
            }

            if (name.Length > 50)
            {
                throw new ValidationException("Name cannot exceed 50 characters.");
            }

            return name;
        }


        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || email.Contains(' '))
            {
                throw new ValidationException("Email cannot be empty or contain spaces.");
            }

            // Email regex explanation:
            // [^@\s]+ matches one or more characters that are not '@' or whitespace
            // @ matches the '@' character
            // [^@\s]+ matches one or more characters that are not '@' or whitespace
            // \. matches the '.' character
            // [^@\s]+ matches one or more characters that are not '@' or whitespace
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                throw new ValidationException("Email format is invalid.");
            }

            if (email.Length > 100)
            {
                throw new ValidationException("Email cannot exceed 100 characters.");
            }

            return email;
        }

        public static ContactTypeEnum ValidateContactType(string contactType)
        {
            switch (contactType)
            {
                case "Family":
                    return ContactTypeEnum.Family;
                case "Friend":
                    return ContactTypeEnum.Friend;
                case "Work":
                    return ContactTypeEnum.Work;
                case "Other":
                    return ContactTypeEnum.Other;
                default:
                    throw new ValidationException("Contact Type is invalid. Must be Family, Friend, Work, or Other.");
            }
        }
    }
}
