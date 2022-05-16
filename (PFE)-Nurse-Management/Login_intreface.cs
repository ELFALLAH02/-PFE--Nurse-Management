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
            //remplisssage de DataSet
            ClassVrariables.cmd = new SqlCommand("select * from admine", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "login");
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
           
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
            if (guna2TextBox2.Text == string.Empty || guna2TextBox1.Text == string.Empty)
            {
                guna2TextBox2.BorderThickness = 3;
                guna2TextBox2.BorderColor = Color.Red;
                guna2TextBox1.BorderColor = Color.Red;
                guna2TextBox1.BorderThickness = 3;
               
            }
            else
            {
                
                if (ClassVrariables.ds.Tables["login"].Rows[0]["Username"].ToString() == guna2TextBox2.Text && ClassVrariables.ds.Tables["login"].Rows[0]["Password"].ToString() == guna2TextBox1.Text)
                {
                    MessageBox.Show("Welcome");
                }
                else
                {
                    MessageBox.Show("Username or Password Not Right");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //btn Showeye
            if (showeye.CanSelect)
            {
                guna2TextBox1.PasswordChar = '\0';
                this.SendToBack();
                eyeshow.BringToFront();
            }
        }

        private void eyeshow_Click(object sender, EventArgs e)
        {
            if (eyeshow.CanSelect)
            {
                guna2TextBox1.PasswordChar = '•';
                this.SendToBack();
                showeye.BringToFront();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == ClassVrariables.ds.Tables["login"].Rows[0]["Username"].ToString())
            {
                guna2TextBox2.BorderColor = Color.Green;
            }
            else if (guna2TextBox2.Text == string.Empty)
            {
                guna2TextBox2.BorderColor = Color.Red;
            }
            else
            {
                guna2TextBox2.BorderColor = Color.Red;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == ClassVrariables.ds.Tables["login"].Rows[0]["Password"].ToString())
            {
                guna2TextBox1.BorderColor = Color.Green;
            }
            else if (guna2TextBox1.Text == string.Empty)
            {
                guna2TextBox1.BorderColor = Color.Red;
            }
            else
            {
                guna2TextBox1.BorderColor = Color.Red;
            }
        }
    }
}
