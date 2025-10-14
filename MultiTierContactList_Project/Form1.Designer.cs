namespace MultiTierContactList_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxInputs = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.groupBoxContactsList = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MultiTierContactList_Project.Database1DataSet();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxInputs.SuspendLayout();
            this.groupBoxContactsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnClearFields);
            this.groupBoxActions.Controls.Add(this.btnAddContact);
            this.groupBoxActions.Controls.Add(this.btnUpdateContact);
            this.groupBoxActions.Controls.Add(this.btnDeleteContact);
            this.groupBoxActions.Controls.Add(this.btnSearch);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxActions.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxActions.Location = new System.Drawing.Point(480, 15);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxActions.Size = new System.Drawing.Size(250, 293);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SlateGray;
            this.btnClearFields.FlatAppearance.BorderSize = 0;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(20, 235);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(210, 40);
            this.btnClearFields.TabIndex = 4;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.FlatAppearance.BorderSize = 0;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.Location = new System.Drawing.Point(20, 35);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(210, 40);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateContact.FlatAppearance.BorderSize = 0;
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateContact.ForeColor = System.Drawing.Color.White;
            this.btnUpdateContact.Location = new System.Drawing.Point(20, 85);
            this.btnUpdateContact.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(210, 40);
            this.btnUpdateContact.TabIndex = 1;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.UseVisualStyleBackColor = false;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteContact.FlatAppearance.BorderSize = 0;
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteContact.ForeColor = System.Drawing.Color.White;
            this.btnDeleteContact.Location = new System.Drawing.Point(20, 135);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(210, 40);
            this.btnDeleteContact.TabIndex = 2;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(20, 185);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxInputs
            // 
            this.groupBoxInputs.Controls.Add(this.txtEmail);
            this.groupBoxInputs.Controls.Add(this.txtLastName);
            this.groupBoxInputs.Controls.Add(this.txtFirstName);
            this.groupBoxInputs.Controls.Add(this.txtContactNumber);
            this.groupBoxInputs.Controls.Add(this.lblEmail);
            this.groupBoxInputs.Controls.Add(this.lblLastName);
            this.groupBoxInputs.Controls.Add(this.lblFirstName);
            this.groupBoxInputs.Controls.Add(this.lblContactNumber);
            this.groupBoxInputs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInputs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxInputs.Location = new System.Drawing.Point(15, 15);
            this.groupBoxInputs.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxInputs.Name = "groupBoxInputs";
            this.groupBoxInputs.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxInputs.Size = new System.Drawing.Size(450, 293);
            this.groupBoxInputs.TabIndex = 1;
            this.groupBoxInputs.TabStop = false;
            this.groupBoxInputs.Text = "Contact Information";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(180, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(180, 184);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 30);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(180, 127);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 30);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContactNumber.Location = new System.Drawing.Point(180, 70);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(240, 30);
            this.txtContactNumber.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(30, 243);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLastName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLastName.Location = new System.Drawing.Point(30, 187);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFirstName.Location = new System.Drawing.Point(30, 131);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContactNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblContactNumber.Location = new System.Drawing.Point(30, 75);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(142, 23);
            this.lblContactNumber.TabIndex = 0;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // groupBoxContactsList
            // 
            this.groupBoxContactsList.Controls.Add(this.dgvContacts);
            this.groupBoxContactsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxContactsList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxContactsList.Location = new System.Drawing.Point(15, 310);
            this.groupBoxContactsList.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxContactsList.Name = "groupBoxContactsList";
            this.groupBoxContactsList.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxContactsList.Size = new System.Drawing.Size(730, 430);
            this.groupBoxContactsList.TabIndex = 3;
            this.groupBoxContactsList.TabStop = false;
            this.groupBoxContactsList.Text = "Contacts List";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.ColumnHeadersHeight = 29;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContacts.DataSource = this.database1DataSetBindingSource;
            this.dgvContacts.Location = new System.Drawing.Point(13, 40);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(704, 377);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 760);
            this.Controls.Add(this.groupBoxInputs);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxContactsList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact List Manager";
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxInputs.ResumeLayout(false);
            this.groupBoxInputs.PerformLayout();
            this.groupBoxContactsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Group Boxes
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.GroupBox groupBoxContactsList;

        // Input Controls
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;

        // Labels
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;

        // Buttons
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnSearch;

        // DataGridView Columns
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button btnClearFields;
    }
}