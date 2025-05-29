using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net; // Ensure you have the BCrypt.Net NuGet package installed
namespace POS_System
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }


        private void signUp_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // Check if username already exists
            string userNameQuery = "SELECT COUNT(*) FROM users WHERE Username = @Username";
            bool usernameExists = false;

            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(userNameQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                            usernameExists = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking username: " + ex.Message);
                    return;
                }
            }

            if (usernameExists)
            {
                MessageBox.Show("Username already exists");
                return;
            }

            string role = "admin";

            string insertQuery = "INSERT INTO users (username, password, role) VALUES (@Username, @Password, @role);";
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Ensure you pass hashed password
                        command.Parameters.AddWithValue("@role", role);

                        // Debugging: Check if the parameters are being passed correctly
                        MessageBox.Show("Inserting Username: " + username + " and Password: " + password);

                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Rows affected: " + result); // Should show 1 if successful
                    }
                    MessageBox.Show("Sign up successful!");
                    loginForm login = new loginForm();
                    login.Show();
                    this.Hide(); // Use Hide instead of Close to keep the form in memory
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting user: " + ex.Message);
                }
            }
        }


    }
}
