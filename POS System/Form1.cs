using System;
using System.Drawing;
using System.Windows.Forms;
namespace POS_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Example drawing on the form using Graphics
            Graphics g = e.Graphics;
            g.DrawString("Login",new Font("Arial", 24), Brushes.Black, new PointF(this.Width/2-20, 100));
            g.DrawString("Email", new Font("Arial", 15), Brushes.Black, new PointF(50, 140));
            g.DrawString("Password", new Font("Arial", 15), Brushes.Black, new PointF(50, 220));

            g.DrawString("Remember Me", new Font("Arial", 8), Brushes.Black, new PointF(50, 300));
            g.DrawString("Forgot Password?", new Font("Arial", 15), Brushes.Black, new PointF(50, 380));
            g.DrawString("Login", new Font("Arial", 15), Brushes.Black, new PointF(50, 460));
        }
    }
}
