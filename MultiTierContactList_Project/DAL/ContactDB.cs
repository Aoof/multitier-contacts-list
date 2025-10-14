using MultiTierContactList_Project.BLL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
                return contacts;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
                return contacts;
            }
        }

        public static void Insert(Contact insertable)
        {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("INSERT INTO Contact VALUES(@id, @FirstName, @LastName, @Email)", connection);
                sqlCommand.Parameters.AddWithValue("@id", insertable.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", insertable.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", insertable.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", insertable.Email);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
        }

        public static void Delete(Contact contact) {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("DELETE FROM Contact WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", contact.Id);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
        }

        public static void Update(Contact updatable)
        {
            try
            {
                connection = DatabaseConnection.GetConnection();
                sqlCommand = new SqlCommand("UPDATE Contact SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", updatable.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", updatable.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", updatable.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", updatable.Email);
                sqlCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                DatabaseConnection.CloseConnection();
            }
        }
    }
}
