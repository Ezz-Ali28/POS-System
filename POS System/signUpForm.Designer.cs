namespace POS_System
{
    partial class signUpForm
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
            label1 = new Label();
            password = new Label();
            userName = new Label();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25F);
            label1.Location = new Point(347, 30);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(51, 275);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 8;
            password.Text = "Password";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(51, 202);
            userName.Name = "userName";
            userName.Size = new Size(60, 15);
            userName.TabIndex = 7;
            userName.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(51, 293);
            passwordTextBox.MaximumSize = new Size(268, 30);
            passwordTextBox.MinimumSize = new Size(268, 30);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(268, 30);
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TabIndex = 6;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(51, 220);
            userNameTextBox.MaximumSize = new Size(268, 30);
            userNameTextBox.MinimumSize = new Size(268, 30);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(268, 30);
            userNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 87);
            textBox1.MaximumSize = new Size(268, 30);
            textBox1.MinimumSize = new Size(268, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 30);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 154);
            textBox2.MaximumSize = new Size(268, 30);
            textBox2.MinimumSize = new Size(268, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 30);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 136);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 11;
            label3.Text = "Second Name";
            // 
            // login
            // 
            login.BackColor = Color.DarkCyan;
            login.ForeColor = Color.Black;
            login.Location = new Point(347, 369);
            login.Name = "login";
            login.Size = new Size(75, 38);
            login.TabIndex = 13;
            login.Text = "Sign Up";
            login.UseVisualStyleBackColor = false;
            login.Click += signUp_Click;
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Name = "signUpForm";
            Text = "signUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label password;
        private Label userName;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button login;
    }
}