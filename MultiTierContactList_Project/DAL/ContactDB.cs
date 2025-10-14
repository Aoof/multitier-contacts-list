using MultiTierContactList_Project.BLL;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MultiTierContactList_Project.DAL
{
    internal class ContactDB
    {
        private static SqlConnection connection = DatabaseConnection.GetConnection();
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
                DatabaseConnection.CloseConnection();
                return contacts;
            }
            catch (SqlException ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
            catch (System.Exception ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
        }

        public static void Insert(Contact entity)
        {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("INSERT INTO Contact VALUES(@id, @FirstName, @LastName, @Email)", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", entity.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", entity.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", entity.Email);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
            catch (System.Exception ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
        }

        public static void Delete(Contact entity) {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("DELETE FROM Contact WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
            catch (System.Exception ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
        }

        public static void Update(Contact entity)
        {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("UPDATE Contact SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", entity.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", entity.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", entity.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", entity.Email);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
            catch (System.Exception ex)
            {
                DatabaseConnection.CloseConnection();
                throw new System.Exception(ex.Message);
            }
        }
    }
}
