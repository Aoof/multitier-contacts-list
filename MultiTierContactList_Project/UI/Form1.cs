using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MultiTierContactList_Project.BLL;

namespace MultiTierContactList_Project.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Contact.GetAllContacts();
            RefreshDatagridView();
            ConfigureDataGridView();
        }
        
        private void ConfigureDataGridView()
        {
            dgvContacts.AutoGenerateColumns = true;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDatagridView()
        {
            try 
            {
                dgvContacts.DataSource = null;
                dgvContacts.DataSource = Contact.Contacts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvContacts.CurrentRow != null)
                {
                    DataGridViewRow contactRow = dgvContacts.CurrentRow;

                    txtContactNumber.Text = contactRow.Cells[0].Value?.ToString() ?? string.Empty;
                    txtFirstName.Text = contactRow.Cells[1].Value?.ToString() ?? string.Empty;
                    txtLastName.Text = contactRow.Cells[2].Value?.ToString() ?? string.Empty;
                    txtEmail.Text = contactRow.Cells[3].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting contact: " + ex.Message);
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.Id = Convert.ToInt32(txtContactNumber.Text);
                contact.FirstName = txtFirstName.Text;
                contact.LastName = txtLastName.Text;
                contact.Email = txtEmail.Text;

                Contact.Insert(contact);
                RefreshDatagridView();
                ClearFields();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error adding contact: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding contact: " + ex.Message);
            }
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.Id = Convert.ToInt32(txtContactNumber.Text);
                contact.FirstName = txtFirstName.Text;
                contact.LastName = txtLastName.Text;
                contact.Email = txtEmail.Text;
                
                Contact.Update(contact);
                RefreshDatagridView();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating contact: " + ex.Message);
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
                {
                    MessageBox.Show("Please select a contact to delete");
                    return;
                }
                
                if (MessageBox.Show("Are you sure you want to delete this contact?", 
                                   "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Contact contact = new Contact();
                    contact.Id = Convert.ToInt32(txtContactNumber.Text);
                    Contact.Delete(contact);
                    RefreshDatagridView();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting contact: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
                {
                    // If nothing to search, show all contacts
                    Contact.GetAllContacts();
                    RefreshDatagridView();
                    return;
                }

                Contact searchContact = new Contact { Id = Convert.ToInt32(txtContactNumber.Text) };
                Contact.Search(searchContact.Id);
                RefreshDatagridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching contacts: " + ex.Message);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
                Contact.GetAllContacts();
                RefreshDatagridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing fields: " + ex.Message);
            }
        }
        
        private void ClearFields()
        {
            txtContactNumber.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}
