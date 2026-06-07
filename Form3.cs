using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class MainApp : Form
    {
        string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDB;Integrated Security=True";
        string userRole;
        public MainApp(string role)
        {
            InitializeComponent();
            userRole = role;

            // Enable update button only for Admins
            btnUpdate.Enabled = (role == "Admin");

            lblRole.Text = "Logged in as: " + role;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Contacts WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtSearch.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Contact not found.");
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                }
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("You don't have permission to update contacts.");
                return;
            }

            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields before updating.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Contacts SET Phone=@Phone, Address=@Address WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                    MessageBox.Show("Contact updated successfully.");
                else
                    MessageBox.Show("Update failed. Contact may not exist.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userRole != "Admin")
            {
                MessageBox.Show("You don't have permission to add contacts.");
                return;
            }

            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields before adding.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Contacts (Name, Phone, Address) VALUES (@Name, @Phone, @Address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();
                int rowsInserted = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsInserted > 0)
                    MessageBox.Show("Contact added successfully.");
                else
                    MessageBox.Show("Failed to add contact.");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
