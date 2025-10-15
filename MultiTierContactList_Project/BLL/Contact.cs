using MultiTierContactList_Project.DAL;
using System.Collections.Generic;

namespace MultiTierContactList_Project.BLL
{
    internal class Contact
    {
        // private fields
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        private static List<Contact> contacts = null;

        // public properties
        public static List<Contact> Contacts
        {
            get { return contacts; }
        }

        public int Id
        {
            get { return id; }
            set { id = Validator.ValidateContactId(value); }
        }

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = Validator.ValidateName(value); }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = Validator.ValidateName(value); }
        }

        public string Email 
        {
            get { return email; }
            set { email = Validator.ValidateEmail(value); }
        }

        // empty constructor
        public Contact()
        {
            id = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            email = string.Empty;
        }

        // parameterized constructor
        public Contact(int id, string firstName, string lastName, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        // copy constructor
        public Contact(Contact entity)
        {
            id = entity.id;
            firstName = entity.firstName;
            lastName = entity.lastName;
            email = entity.email;
        }

        // public static crud operations

        public static void Insert(Contact entity)
        {
            ContactDB.Insert(entity);
            RefreshContactsList();
        }

        public static void Update(Contact entity)
        {
            ContactDB.Update(entity);
            RefreshContactsList();
        }

        public static void Delete(Contact entity)
        {
            ContactDB.Delete(entity);
            RefreshContactsList();
        }

        public static void Delete(int id)
        {
            Contact tmp = new Contact();
            tmp.Id = id;
            ContactDB.Delete(tmp);
            RefreshContactsList();
        }

        public static void Search(int searchKey)
        {
            GetAllContacts();
            List<Contact> searchResults = new List<Contact>();
            foreach (Contact c in contacts)
            {
                if (c.Id == searchKey)
                {
                    searchResults.Add(c);
                }
            }
            contacts = searchResults;
            

            if (contacts == null || contacts.Count == 0)
            {
                GetAllContacts();
                throw new ContactNotFoundException("No contacts found with the given ID.");
            }
        }

        private static void RefreshContactsList()
        {
            contacts = ContactDB.GetAllContacts();
        }

        public static List<Contact> GetAllContacts()
        {
            contacts = ContactDB.GetAllContacts();
            return contacts;
        }
    }
}
