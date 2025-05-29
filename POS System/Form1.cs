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
    public partial class Form1 : Form
    {
        public static Bitmap chartBitmap;
        
        public static PictureBox ContentCreator
        {
            get { return ((Form1)Application.OpenForms["Form1"])?.contentCreatorPictureBox; }
        }

        public Form1()
        {
            InitializeComponent();
            contentCreatorPictureBox.Size = new Size((int)(this.Width*2), (int)(this.Height*2));
            chartBitmap = new Bitmap(contentCreatorPictureBox.Width, contentCreatorPictureBox.Height);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            contentCreatorPictureBox.Controls.Clear();

            int centerX = 500;
            int startY = 200;

            Label lblTitle = new Label()
            {
                Text = "Add Product",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(centerX - 100, startY)
            };

            startY += 50;
            Label lblName = new Label()
            {
                Text = "Name",
                Location = new Point(centerX - 125, startY),
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            startY += 30;
            TextBox txtName = new TextBox()
            {
                Location = new Point(centerX - 125, startY),
                Width = 300,
                Font = new Font("Segoe UI", 12)
            };

            startY += 50;
            Label lblCategory = new Label()
            {
                Text = "Category",
                Location = new Point(centerX - 125, startY),
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            startY += 30;
            ComboBox cmbCategory = new ComboBox()
            {
                Location = new Point(centerX - 125, startY),
                Width = 300,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 12)
            };
            cmbCategory.Items.AddRange(new string[] { "Drinks", "Fruits", "Snacks", "Other" });

            startY += 50;
            Label lblPrice = new Label()
            {
                Text = "Price",
                Location = new Point(centerX - 125, startY),
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            startY += 30;
            TextBox txtPrice = new TextBox()
            {
                Location = new Point(centerX - 125, startY),
                Width = 150,
                Font = new Font("Segoe UI", 12)
            };

            startY += 50;
            Label lblQuantity = new Label()
            {
                Text = "Quantity",
                Location = new Point(centerX - 125, startY),
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            startY += 30;
            TextBox txtQuantity = new TextBox()
            {
                Location = new Point(centerX - 125, startY),
                Width = 150,
                Font = new Font("Segoe UI", 12)
            };

            startY += 50;
            Button btnSave = new Button()
            {
                Text = "Save",
                Location = new Point(centerX - 40, startY),
                Width = 100,
                Height = 40,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            contentCreatorPictureBox.Controls.Add(lblTitle);
            contentCreatorPictureBox.Controls.Add(lblName);
            contentCreatorPictureBox.Controls.Add(txtName);
            contentCreatorPictureBox.Controls.Add(lblCategory);
            contentCreatorPictureBox.Controls.Add(cmbCategory);
            contentCreatorPictureBox.Controls.Add(lblPrice);
            contentCreatorPictureBox.Controls.Add(txtPrice);
            contentCreatorPictureBox.Controls.Add(lblQuantity);
            contentCreatorPictureBox.Controls.Add(txtQuantity);
            contentCreatorPictureBox.Controls.Add(btnSave);

            Bitmap resized = new Bitmap(chartBitmap, contentCreatorPictureBox.Width, contentCreatorPictureBox.Height);
            contentCreatorPictureBox.Image = resized;
        }


        private void sales_Click(object sender, EventArgs e)
        {
            contentCreatorPictureBox.Controls.Clear();

            int centerX = 650;
            int startY = 200;

            Label lblTitle = new Label()
            {
                Text = "Sales",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(centerX - 200, startY),
                AutoSize = true
            };

            startY += 50;
            TextBox txtSearch = new TextBox()
            {
                Location = new Point(centerX - 300, startY),
                Width = 300,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.Gray,
                Text = "Selved products"
            };

            // Simulate placeholder behavior
            txtSearch.GotFocus += (s, ev) =>
            {
                if (txtSearch.Text == "Selved products")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };
            txtSearch.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Selved products";
                    txtSearch.ForeColor = Color.Gray;
                }
            };

            startY += 50;
            ListBox lstProducts = new ListBox()
            {
                Location = new Point(centerX - 400, startY),
                Size = new Size(200, 300),
                Font = new Font("Segoe UI", 12)
            };
            lstProducts.Items.AddRange(new string[] { "Board\n2022", "Lojat\n2oo3", "Eggs\n2nH", "Mils\n2085", "Oveage\n2613" });

            Panel pnlCurrentSale = new Panel()
            {
                Location = new Point(centerX + 50, startY),
                Size = new Size(250, 300),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblCurrentSaleTitle = new Label()
            {
                Text = "Current Sale",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            Label lblApple = new Label() { Text = "Apple", Location = new Point(10, 50), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblApplePrice = new Label() { Text = "3.00", Location = new Point(150, 50), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblBanara = new Label() { Text = "Banara", Location = new Point(10, 90), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblBanaraPrice = new Label() { Text = "0.50", Location = new Point(150, 90), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblTotal = new Label() { Text = "Total", Location = new Point(10, 130), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblTotalPrice = new Label() { Text = "3.50", Location = new Point(150, 130), AutoSize = true, Font = new Font("Segoe UI", 12) };
            Label lblSecondTotal = new Label() { Text = "Total", Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(10, 170), AutoSize = true };
            Label lblSecondTotalPrice = new Label() { Text = "3.50", Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(150, 170), AutoSize = true };
            Button btnContenSale = new Button()
            {
                Text = "Content Sale",
                Location = new Point(50, 210),
                Width = 150,
                Height = 40,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            pnlCurrentSale.Controls.Add(lblCurrentSaleTitle);
            pnlCurrentSale.Controls.Add(lblApple);
            pnlCurrentSale.Controls.Add(lblApplePrice);
            pnlCurrentSale.Controls.Add(lblBanara);
            pnlCurrentSale.Controls.Add(lblBanaraPrice);
            pnlCurrentSale.Controls.Add(lblTotal);
            pnlCurrentSale.Controls.Add(lblTotalPrice);
            pnlCurrentSale.Controls.Add(lblSecondTotal);
            pnlCurrentSale.Controls.Add(lblSecondTotalPrice);
            pnlCurrentSale.Controls.Add(btnContenSale);

            contentCreatorPictureBox.Controls.Add(lblTitle);
            contentCreatorPictureBox.Controls.Add(txtSearch);
            contentCreatorPictureBox.Controls.Add(lstProducts);
            contentCreatorPictureBox.Controls.Add(pnlCurrentSale);

            Bitmap resized = new Bitmap(chartBitmap, contentCreatorPictureBox.Width, contentCreatorPictureBox.Height);
            contentCreatorPictureBox.Image = resized;
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            contentCreatorPictureBox.Controls.Clear();

            // Shift to the left by 50 pixels
            int centerX = 500;
            int startY = 250;

            Label lblTitle = new Label()
            {
                Text = "Invoice Preview",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(centerX - 100, startY),
                AutoSize = true
            };

            Button btnAddProfel = new Button()
            {
                Text = "Add Profile",
                Location = new Point(centerX + 150, startY),
                Width = 120,
                Height = 35,
                BackColor = Color.LightGray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            startY += 60;
            Label lblItemHeader = new Label()
            {
                Text = "Item",
                Location = new Point(centerX - 200, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label lblPriceHeader1 = new Label()
            {
                Text = "Price",
                Location = new Point(centerX - 50, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label lblPriceHeader2 = new Label()
            {
                Text = "Price",
                Location = new Point(centerX + 100, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };

            startY += 40;
            Label lblApple = new Label() { Text = "Apple", Location = new Point(centerX - 200, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblApplePrice1 = new Label() { Text = "3.00", Location = new Point(centerX - 50, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblApplePrice2 = new Label() { Text = "2.00", Location = new Point(centerX + 100, startY), Font = new Font("Segoe UI", 12), AutoSize = true };

            startY += 30;
            Label lblBanana1 = new Label() { Text = "Banana", Location = new Point(centerX - 200, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblBananaPrice1 = new Label() { Text = "0.50", Location = new Point(centerX - 50, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblBananaPrice2 = new Label() { Text = "0.00", Location = new Point(centerX + 100, startY), Font = new Font("Segoe UI", 12), AutoSize = true };

            startY += 30;
            Label lblBanana2 = new Label() { Text = "Banana", Location = new Point(centerX - 200, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblBanana2Price1 = new Label() { Text = "2.00", Location = new Point(centerX - 50, startY), Font = new Font("Segoe UI", 12), AutoSize = true };
            Label lblBanana2Price2 = new Label() { Text = "1.00", Location = new Point(centerX + 100, startY), Font = new Font("Segoe UI", 12), AutoSize = true };

            startY += 30;
            Label lblTotal = new Label() { Text = "Total", Location = new Point(centerX - 200, startY), Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true };

            Label lblSubtotal = new Label()
            {
                Text = "Subtotal",
                Location = new Point(centerX, startY + 20),
                Font = new Font("Segoe UI", 12),
                AutoSize = true
            };
            Label lblSubtotalValue = new Label()
            {
                Text = "4.00",
                Location = new Point(centerX + 100, startY + 20),
                Font = new Font("Segoe UI", 12),
                AutoSize = true
            };

            Label lblFinalTotal = new Label()
            {
                Text = "Total",
                Location = new Point(centerX, startY + 50),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label lblFinalTotalValue = new Label()
            {
                Text = "3.50",
                Location = new Point(centerX + 100, startY + 50),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };

            Button btnContentSale = new Button()
            {
                Text = "Content Sale",
                Location = new Point(centerX - 50, startY + 90),
                Width = 150,
                Height = 40,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            // Add controls
            contentCreatorPictureBox.Controls.Add(lblTitle);
            contentCreatorPictureBox.Controls.Add(btnAddProfel);
            contentCreatorPictureBox.Controls.Add(lblItemHeader);
            contentCreatorPictureBox.Controls.Add(lblPriceHeader1);
            contentCreatorPictureBox.Controls.Add(lblPriceHeader2);
            contentCreatorPictureBox.Controls.Add(lblApple);
            contentCreatorPictureBox.Controls.Add(lblApplePrice1);
            contentCreatorPictureBox.Controls.Add(lblApplePrice2);
            contentCreatorPictureBox.Controls.Add(lblBanana1);
            contentCreatorPictureBox.Controls.Add(lblBananaPrice1);
            contentCreatorPictureBox.Controls.Add(lblBananaPrice2);
            contentCreatorPictureBox.Controls.Add(lblBanana2);
            contentCreatorPictureBox.Controls.Add(lblBanana2Price1);
            contentCreatorPictureBox.Controls.Add(lblBanana2Price2);
            contentCreatorPictureBox.Controls.Add(lblTotal);
            contentCreatorPictureBox.Controls.Add(lblSubtotal);
            contentCreatorPictureBox.Controls.Add(lblSubtotalValue);
            contentCreatorPictureBox.Controls.Add(lblFinalTotal);
            contentCreatorPictureBox.Controls.Add(lblFinalTotalValue);
            contentCreatorPictureBox.Controls.Add(btnContentSale);

            Bitmap resized = new Bitmap(chartBitmap, contentCreatorPictureBox.Width, contentCreatorPictureBox.Height);
            contentCreatorPictureBox.Image = resized;
        }

        private void products_Click(object sender, EventArgs e)
        {
            
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            contentCreatorPictureBox.Controls.Clear();

            int centerX = 500;
            int startY = 300;

            // Title
            Label lblTitle = new Label()
            {
                Text = "Customers",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(centerX - 100, startY),
                AutoSize = true
            };

            // Addgest button
            Button btnAdgust = new Button()
            {
                Text = "Adgust",
                Location = new Point(centerX + 150, startY),
                Width = 120,
                Height = 35,
                BackColor = Color.LightGray,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            // Table headers
            startY += 60;
            Label lblNameHeader = new Label()
            {
                Text = "Name",
                Location = new Point(centerX - 250, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label lblEmailHeader1 = new Label()
            {
                Text = "Email",
                Location = new Point(centerX - 50, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            Label lblEmailHeader2 = new Label()
            {
                Text = "Email",
                Location = new Point(centerX + 150, startY),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };

            // Customer rows
            string[,] customers = new string[,]
            {
                {"John Doe", "Joro Swith", "jshe@iccom"},
                {"Michael Join", "Michael Johnson", "mi-ato@com"},
                {"Entty Brown", "Entty Brown", "mtrryd@com"},
                {"Band Wilson", "Dand Willson", "divillo@com"},
                {"Sarah Tayler", "Sarah Tayler", "zarah@com"}
            };

            for (int i = 0; i < customers.GetLength(0); i++)
            {
                startY += 30;
                Label lblName = new Label()
                {
                    Text = customers[i, 0],
                    Location = new Point(centerX - 250, startY),
                    Font = new Font("Segoe UI", 12),
                    AutoSize = true
                };
                Label lblEmail1 = new Label()
                {
                    Text = customers[i, 1],
                    Location = new Point(centerX - 50, startY),
                    Font = new Font("Segoe UI", 12),
                    AutoSize = true
                };
                Label lblEmail2 = new Label()
                {
                    Text = customers[i, 2],
                    Location = new Point(centerX + 150, startY),
                    Font = new Font("Segoe UI", 12),
                    AutoSize = true
                };

                contentCreatorPictureBox.Controls.Add(lblName);
                contentCreatorPictureBox.Controls.Add(lblEmail1);
                contentCreatorPictureBox.Controls.Add(lblEmail2);
            }

            // Add to PictureBox
            contentCreatorPictureBox.Controls.Add(lblTitle);
            contentCreatorPictureBox.Controls.Add(btnAdgust);
            contentCreatorPictureBox.Controls.Add(lblNameHeader);
            contentCreatorPictureBox.Controls.Add(lblEmailHeader1);
            contentCreatorPictureBox.Controls.Add(lblEmailHeader2);

            Bitmap resized = new Bitmap(chartBitmap, contentCreatorPictureBox.Width, contentCreatorPictureBox.Height);
            contentCreatorPictureBox.Image = resized;
        }
    }
}
