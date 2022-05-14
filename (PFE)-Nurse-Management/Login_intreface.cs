using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PFE__Nurse_Management
{
    public partial class Login_intreface : UserControl
    {
        public Login_intreface()
        {
            InitializeComponent();
        }

        private void Login_intreface_Load(object sender, EventArgs e)
        {
            guna2Shapes1.Visible = false;
            button2.Visible = false;

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (eyeshow.CanSelect)
            {
                guna2TextBox1.PasswordChar = '\0';
                this.SendToBack();
                showeye.BringToFront();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (showeye.CanSelect)
            {
                guna2TextBox1.PasswordChar = '•';
                this.SendToBack();
                eyeshow.BringToFront();
            }
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.CanSelect)
            {
                button2.Visible = true;
                guna2Shapes1.Visible = true;
                guna2Shapes1.Location = new Point(3, 98);
                button2.Location = new Point(326, 124);
                guna2Shapes1.BackColor = Color.FromArgb(0, 158, 251);

                button1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.CanSelect) 
            {
                guna2Shapes1.Visible = false;
                button2.Visible = false;
                button1.Show();
            
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
