using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class MainFormcs : Form
    {
        public MainFormcs()
        {
            InitializeComponent();
            SetupUI();
        }
        private void SetupUI()
        {
            this.Text = "Main Page";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ===== Sidebar Panel =====
            Panel sidebar = new Panel()
            {
                Dock = DockStyle.Left,
                Width = 180,
                BackColor = Color.FromArgb(240, 240, 240)
            };
            this.Controls.Add(sidebar);

            // ===== Menu Buttons =====
            int top = 20;
            string[] menuItems = {
                "🏠 Home",
                "📦 Products",
                "➕ Add a New Product",
                "💰 Sales",
                "📄 Invoices",
                "👥 Customers",
                "⚙️ Settings",
                "🔒 Logout"
            };

            foreach (string item in menuItems)
            {
                Button btn = new Button()
                {
                    Text = item,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Location = new Point(0, top),
                    Width = sidebar.Width,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    FlatAppearance = { BorderSize = 0 }
                };
                sidebar.Controls.Add(btn);
                top += 45;
            }

            // ===== Main Content Panel =====
            Panel contentPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(contentPanel);

            // ===== Add Product Controls =====
            Label lblTitle = new Label()
            {
                Text = "Add Product",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(230, 30),
                AutoSize = true
            };

            Label lblName = new Label() { Text = "Name", Location = new Point(230, 70), AutoSize = true };
            TextBox txtName = new TextBox() { Location = new Point(230, 90), Width = 250 };

            Label lblCategory = new Label() { Text = "Category", Location = new Point(230, 120), AutoSize = true };
            ComboBox cmbCategory = new ComboBox()
            {
                Location = new Point(230, 140),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbCategory.Items.AddRange(new string[] { "Drinks", "Fruits", "Snacks", "Other" });

            Label lblPrice = new Label() { Text = "Price", Location = new Point(230, 180), AutoSize = true };
            TextBox txtPrice = new TextBox() { Location = new Point(230, 200), Width = 120 };
            Label lblQuantity=new Label() {
                Text = "Quantity",
                Location = new Point(230, 230),
                AutoSize = true
            };
            TextBox txtQuantity = new TextBox()
            {
                Location = new Point(230, 250),
                Width = 120
            };

            Button btnSave = new Button()
            {
                Text = "Save",
                Location = new Point(350, 300),
                Width = 80,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSave.Click += (s, e) =>
            {
                MessageBox.Show("Product Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Add controls to content panel
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Controls.Add(lblName);
            contentPanel.Controls.Add(txtName);
            contentPanel.Controls.Add(lblCategory);
            contentPanel.Controls.Add(cmbCategory);
            contentPanel.Controls.Add(lblPrice);
            contentPanel.Controls.Add(txtPrice);
            contentPanel.Controls.Add(txtQuantity);
            contentPanel.Controls.Add(btnSave);
            contentPanel.Controls.Add(lblQuantity);
        }
    }
}
