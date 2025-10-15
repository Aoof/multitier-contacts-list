using MultiTierContactList_Project.BLL;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MultiTierContactList_Project.DAL
{
    internal class ContactDB
    {
        private static SqlConnection connection = null;
        private static SqlCommand sqlCommand = new SqlCommand();

        public static List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("SELECT * FROM Contact", connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                while (sqlDataReader.Read())
                {
                    Contact contact = new Contact();
                    contact.Id = sqlDataReader.GetInt32(0);
                    contact.FirstName = sqlDataReader.GetString(1);
                    contact.LastName = sqlDataReader.GetString(2);
                    contact.Email = sqlDataReader.GetString(3);
                    contacts.Add(contact);
                }
                sqlDataReader.Close();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
            return contacts;
        }

        public static void Insert(Contact entity)
        {
            try
            {
                List<Contact> contacts = GetAllContacts();
                foreach (var contact in contacts)
                {
                   if (contact.Id == entity.Id) {
                        throw new DuplicateContactIdException("A contact with the same ID already exists.");
                   }

                   if (contact.Email == entity.Email) {
                        throw new DuplicateEmailException("A contact with the same email already exists.");
                    }
                }
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("INSERT INTO Contact VALUES(@id, @FirstName, @LastName, @Email)", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", entity.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", entity.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", entity.Email);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public static void Delete(Contact entity) {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("DELETE FROM Contact WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public static void Update(Contact entity)
        {
            try
            {
                List<Contact> contacts = GetAllContacts();
                foreach (var contact in contacts)
                {
                   if (contact.Id != entity.Id && contact.Email == entity.Email) {
                        throw new DuplicateEmailException("A contact with the same email already exists.");
                    }
                }
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("UPDATE Contact SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", entity.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", entity.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", entity.Email);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }
    }
}
