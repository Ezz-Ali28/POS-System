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
            string userNameQuery = "Select COUNT(*) FROM users WHERE Username = @Username";
            string passwordQuery = "Select COUNT(*) FROM users WHERE Password = @Password";
            bool flag = false;
            // Using block ensures disposal of resources
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(userNameQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        SqlDataReader reader = command.ExecuteReader();
                        int count = reader.FieldCount;

                        if (count > 0)
                        {
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if(!flag)
            {
                MessageBox.Show("Username already exists");
                return;
            }
            
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(userNameQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = command.ExecuteReader();
                        int count = reader.FieldCount;

                        if (count > 0)
                        {
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if(!flag)
            {
                MessageBox.Show("Password already exists");
                return;
            }
            // SQL query to check if username and password match
            string query = "INSERT INTO users (username, password,role) VALUES (@Username, @Password,@role)";
            // Using block ensures disposal of resources
            using (SqlConnection connection = new SqlConnection(loginForm.connectionString))
            {
                

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@role", "admin");
                    MessageBox.Show("Sign up successful!");
                    loginForm login = new loginForm();
                    login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
