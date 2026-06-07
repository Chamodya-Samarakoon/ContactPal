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

namespace VisualProgrammingProject
{
    public partial class Settings : Form
    {

        string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=projectDB;Integrated Security=True";
        public Settings()
        {
            InitializeComponent();
            btnUpdate.Click += btnUpdate_Click;
            btnCancel.Click += (s, e) => this.Close();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string currentPassword = txtCurrentPass.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();
            string confirmPassword = txtConfirmPass.Text.Trim();


            

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Verify current credentials using Username
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @CurrentPassword";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        checkCmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 1)
                        {
                            // Update password 
                            string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);

                                updateCmd.Parameters.AddWithValue("@Username", username);

                                int rows = updateCmd.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    MessageBox.Show("Settings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update settings. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or current password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
