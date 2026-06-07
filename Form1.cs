using Microsoft.VisualBasic.Logging;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class Register : Form
    {
        string connectionString = "Data Source=(localdb)\\Local; Initial Catalog=projectDB; Integrated Security=True";
        public Register()
        {
            InitializeComponent();
            cmbRole.Items.Add("User");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; //defalt user
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Email, Username, Password, Role) VALUES (@Email, @Username, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registration successful!");

                    // Go to login form
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }
    }
}
