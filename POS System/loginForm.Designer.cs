namespace POS_System
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            title = new Label();
            userName = new Label();
            password = new Label();
            forgotPassword = new LinkLabel();
            login = new Button();
            isNewUser = new Label();
            register = new LinkLabel();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(80, 132);
            userNameTextBox.MaximumSize = new Size(268, 30);
            userNameTextBox.MinimumSize = new Size(268, 30);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(268, 30);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(80, 221);
            passwordTextBox.MaximumSize = new Size(268, 30);
            passwordTextBox.MinimumSize = new Size(268, 30);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(268, 30);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial", 25F);
            title.Location = new Point(152, 28);
            title.Name = "title";
            title.Size = new Size(98, 39);
            title.TabIndex = 2;
            title.Text = "Login";
            title.Click += label1_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(80, 101);
            userName.Name = "userName";
            userName.Size = new Size(60, 15);
            userName.TabIndex = 3;
            userName.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(80, 187);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 4;
            password.Text = "Password";
            // 
            // forgotPassword
            // 
            forgotPassword.AutoSize = true;
            forgotPassword.Location = new Point(80, 284);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(100, 15);
            forgotPassword.TabIndex = 5;
            forgotPassword.TabStop = true;
            forgotPassword.Text = "Forgot Password?";
            // 
            // login
            // 
            login.BackColor = Color.DarkCyan;
            login.ForeColor = Color.Black;
            login.Location = new Point(152, 336);
            login.Name = "login";
            login.Size = new Size(75, 38);
            login.TabIndex = 6;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // isNewUser
            // 
            isNewUser.AutoSize = true;
            isNewUser.Location = new Point(134, 387);
            isNewUser.Name = "isNewUser";
            isNewUser.Size = new Size(62, 15);
            isNewUser.TabIndex = 7;
            isNewUser.Text = "New User?";
            // 
            // register
            // 
            register.AutoSize = true;
            register.Location = new Point(192, 387);
            register.Name = "register";
            register.Size = new Size(49, 15);
            register.TabIndex = 8;
            register.TabStop = true;
            register.Text = "Register";
            register.LinkClicked += register_LinkClicked_1;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(register);
            Controls.Add(isNewUser);
            Controls.Add(login);
            Controls.Add(forgotPassword);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(title);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Name = "loginForm";
            Text = "loginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label title;
        private Label userName;
        private Label password;
        private LinkLabel forgotPassword;
        private Button login;
        private Label isNewUser;
        private LinkLabel register;
    }
}
