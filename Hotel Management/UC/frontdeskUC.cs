using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel_Management.UC
{
    public partial class frontdeskUC : UserControl
    {
        DataClasses1DataContext dbClients = new DataClasses1DataContext();
        public frontdeskUC()
        {
            InitializeComponent();
        }
        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();

        }
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();

        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxPhoneNo.Text != "" && textBoxAddress.Text != "")
            {
                ClientsTable clientsTable = new ClientsTable();
                clientsTable.FirstName = textBoxFirstName.Text;
                clientsTable.LastName = textBoxLastName.Text;
                clientsTable.Address = textBoxAddress.Text;
                clientsTable.PhoneNumber = (int)Int64.Parse(textBoxPhoneNo.Text);
                dbClients.ClientsTables.InsertOnSubmit(clientsTable);
                dbClients.SubmitChanges();
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
            {

                Clear();
            }
            private void tabPageSearchClient_Leave(object sender, EventArgs e)
            {
                textBoxPhoneNo1.Clear();
            }
            private void textBoxPhoneNoSearch_TextChanged(object sender, EventArgs e)
            {
                string searchQuery = textBoxPhoneNoSearch.Text;
                var searchResults = from clients in dbClients.ClientsTables
                                    where clients.PhoneNumber.ToString().Contains(searchQuery)
                                    select new
                                    {
                                        clients.Client_ID,
                                        clients.FirstName,
                                        clients.LastName,
                                        clients.PhoneNumber,
                                        clients.Address
                                        // Add other columns as needed
                                    };

                // Bind the search results to the DataGridView
                gridview1.DataSource = searchResults.ToList();
            }
        private void UpdateData()
        {
            {
                // Assuming db is your instance of YourDataContext
                int phone = (int)Int64.Parse(textBoxPhoneNo1.Text.Trim());

                // Query the database to find the record to update based on the phone number
                var recordToUpdate = dbClients.ClientsTables.FirstOrDefault(x => x.PhoneNumber == phone);
               
                if (recordToUpdate != null)
                {
                    // Update the record with values from the textboxes
                    recordToUpdate.FirstName = textBoxFirstName1.Text.Trim();
                    recordToUpdate.LastName = textBoxLastName1.Text.Trim();
                    recordToUpdate.Address = textBoxAddress1.Text.Trim();

                    // Save changes to the database
                    dbClients.SubmitChanges();

                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteData()
        {
            // Assuming db is your instance of YourDataContext
            var firstName = textBoxFirstName1.Text.Trim();
            var lastName = textBoxLastName1.Text.Trim();
            int phone = (int)Int64.Parse(textBoxPhoneNo1.Text.Trim());
            var address = textBoxAddress1.Text.Trim();

            // Query the database to find the record to delete
            var recordToDelete = dbClients.ClientsTables.FirstOrDefault(x =>
                x.FirstName == firstName &&
                x.LastName == lastName &&
                x.PhoneNumber == phone &&
                x.Address == address);

            if (recordToDelete != null)
            {
                // Delete the record
                dbClients.ClientsTables.DeleteOnSubmit(recordToDelete);

                // Save changes to the database
                dbClients.SubmitChanges();

                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frontdeskUC_Load(object sender, EventArgs e)
        {
            var clientdetails = (from x in dbClients.ClientsTables select x).ToList();
            gridview1.DataSource = clientdetails;
        }

        private void textBoxPhoneNoSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchQuery = textBoxPhoneNoSearch.Text;
            var searchResults = from clients in dbClients.ClientsTables
                                where clients.PhoneNumber.ToString().Contains(searchQuery)
                                select new
                                {
                                    clients.Client_ID,
                                    clients.FirstName,
                                    clients.LastName,
                                    clients.PhoneNumber,
                                    clients.Address
                                    // Add other columns as needed
                                };

            // Bind the search results to the DataGridView
            gridview1.DataSource = searchResults.ToList();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void gridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
