using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace _PFE__Nurse_Management
{
    public partial class Dashboard : KryptonForm
    {
        private const ContentAlignment middleLeft = ContentAlignment.MiddleLeft;
        private const ContentAlignment middleLeft1 = middleLeft;

        public
        System.Drawing.ContentAlignment
        ImageAlign { get; set; }
        
        public Panel PnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }
       
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            closesidebar.Hide();
            closedrop.Hide();
            flowLayoutPanel1.Hide();
            flowLayoutPanel1.Size = new Size(165, 192);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           

        
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closesidebar_Click(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Size = new Size(94, 671);
            guna2GradientButton1.Size = new Size(43, 58);
            guna2GradientButton11.Size = new Size(43, 58);
            guna2GradientButton7.Size = new Size(43, 58);
            guna2GradientButton9.Size = new Size(43, 58);
            guna2GradientButton6.Size = new Size(43, 58);
            guna2GradientButton3.Size = new Size(43, 58);
            guna2GradientButton8.Size = new Size(67, 58);


            guna2GradientButton3.Text = "";
            guna2GradientButton8.Text = "";

            guna2GradientButton1.Text = "";
            guna2GradientButton11.Text = "";
            guna2GradientButton7.Text = "";
            guna2GradientButton9.Text = "";
            guna2GradientButton6.Text = "";
            closesidebar.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Infirmiers inf_inter = new Infirmiers();
            addUserControl(inf_inter);
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {

        }

       

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

  
        private void guna2GradientButton2_Click_2(object sender, EventArgs e)
        {
            opendrop.Hide();
            closedrop.Show();
            //flowLayoutPanel1.Location = new Point(793, 1);
          


            flowLayoutPanel1.Show();

        }

        private void closedrop_Click(object sender, EventArgs e)
        {

        }

        private void closedrop_Click_1(object sender, EventArgs e)
        {
            closedrop.Hide();
            opendrop.Show();
            flowLayoutPanel1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Size = new Size(218, 675);
            //when i click on fisrt button the size //
            guna2GradientButton1.Size = new Size(175, 58);
            guna2GradientButton11.Size = new Size(175, 58);
            guna2GradientButton7.Size = new Size(175, 58);
            guna2GradientButton9.Size = new Size(175, 58);
            guna2GradientButton8.Size = new Size(175, 58);

            guna2GradientButton6.Size = new Size(175, 58);
            guna2GradientButton3.Size = new Size(175, 58);
            /////////////////////////////////////////////////
            guna2GradientButton3.Text = "logout";
            guna2GradientButton1.Text = "Tableau de bord";
            guna2GradientButton11.Text = "Liste Signature";
            guna2GradientButton7.Text = "Liste Note";
            guna2GradientButton9.Text = "Infirmiérs";
            guna2GradientButton6.Text = "Paramétres";
            guna2GradientButton8.Text = "SGE";

            /////////////////////////////////////////////////
            guna2ShadowPanel1.Anchor = AnchorStyles.Left;
            guna2ShadowPanel1.Anchor = AnchorStyles.Bottom;
            guna2ShadowPanel1.Anchor = AnchorStyles.Top;
            guna2ShadowPanel1.Dock = DockStyle.Left;
            closesidebar.Show();
        }
    }
}
