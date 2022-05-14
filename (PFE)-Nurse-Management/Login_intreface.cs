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
    }
}
