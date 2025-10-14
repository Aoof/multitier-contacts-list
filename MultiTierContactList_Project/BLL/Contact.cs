using MultiTierContactList_Project.DAL;
using System.Collections.Generic;

namespace MultiTierContactList_Project.BLL
{
    internal class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        private static List<Contact> contacts = null;
        public static List<Contact> Contacts
        {
            get { return contacts; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        public Contact()
        {
            id = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            email = string.Empty;
        }

        public Contact(int id, string firstName, string lastName, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public Contact(Contact contact)
        {
            id = contact.id;
            firstName = contact.firstName;
            lastName = contact.lastName;
            email = contact.email;
        }

        // public static crud operations

        public static void Insert(Contact insertable)
        {
            ContactDB.Insert(insertable);
            RefreshContactsList();
        }

        public static void Update(Contact updatable)
        {
            ContactDB.Update(updatable);
            RefreshContactsList();
        }

        public static void Delete(Contact contact)
        {
            ContactDB.Delete(contact);
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
            if (contacts == null || contacts.Count == 0)
            {
                GetAllContacts();
                return;
            }
            
            List<Contact> searchResults = new List<Contact>();
            foreach (Contact c in contacts)
            {
                if (c.Id == searchKey)
                {
                    searchResults.Add(c);
                }
            }
            
            if (searchResults.Count > 0)
            {
                contacts = searchResults;
            }
            else
            {
                RefreshContactsList();
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
