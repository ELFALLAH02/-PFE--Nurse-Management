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
    public partial class Infirmiers : UserControl
    {
       
        public Panel PnlContainer
        {
            get { return guna2CustomGradientPanel1; }
            set { guna2CustomGradientPanel1= (Guna.UI2.WinForms.Guna2CustomGradientPanel)value; }
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Clear();
            guna2CustomGradientPanel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        public Infirmiers()
        {
            InitializeComponent();
        }

        private void Infirmiers_Load(object sender, EventArgs e)
        {
            // panel1.Visible = false;
            
            guna2CustomGradientPanel2.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Show();

           
                Add_Infirmiér infr = new Add_Infirmiér();
                addUserControl(infr);
            
          
            

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
