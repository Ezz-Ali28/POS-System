using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS_System
{
    public partial class loginForm : Form
    {
        public static string connectionString = @"Server=DESKTOP-DICV7RS\SQLEXPRESS03;Database=POS_System;Integrated Security=True;";

        public loginForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpForm signUp = new signUpForm();
            signUp.Show();
            this.Hide();
        }
        private void login_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // SQL query to check if username and password match
            string query = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Password = @Password";

            // Using block ensures disposal of resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = command.ExecuteReader();
                        int count = reader.FieldCount;

                        if (count > 0)
                        {
                            // Login successful
                            MessageBox.Show("Login successful!");
                            MainFormcs mainFormcs = new MainFormcs();
                            
                            mainFormcs.Show();
                            this.Hide();
                            
                            // Add code here to navigate to your main application form or perform other actions
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
