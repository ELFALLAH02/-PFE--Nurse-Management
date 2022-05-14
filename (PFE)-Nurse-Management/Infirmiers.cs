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
            get { return panel1; }
            set { panel1= value; }
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Infirmiers()
        {
            InitializeComponent();
        }

        private void Infirmiers_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
            if (guna2GradientButton1.CanSelect)
            {
                //panel1.Size = new Size(832, 495);
                //panel1.Location = new Point(212, 72);
                panel1.Visible = true;
                Add_Infirmiér infr = new Add_Infirmiér();
                addUserControl(infr);
            }
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
