using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierContactList_Project.DAL
{
    internal class DuplicateEmailException : Exception
    {
        DuplicateEmailException() : base("Email already exists in the database.") { }
        public DuplicateEmailException(string message) : base(message) { }
    }

    internal class DuplicateContactIdException : Exception
    {
        DuplicateContactIdException() : base("Contact ID already exists in the database.") { }
        public DuplicateContactIdException(string message) : base(message) { }
    }

    internal class ValidationException : Exception
    {
        ValidationException() : base("Validation error occurred.") { }
        public ValidationException(string message) : base(message) { }
    }

    internal class ContactNotFoundException : Exception
    {
        ContactNotFoundException() : base("Contact not found in the database.") { }
        public ContactNotFoundException(string message) : base(message) { }
    }
}
