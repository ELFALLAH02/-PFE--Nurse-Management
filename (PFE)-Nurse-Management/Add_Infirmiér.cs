using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PFE__Nurse_Management
{
    public partial class Add_Infirmiér : UserControl
    {
        public Panel PnlContainer
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Add_Infirmiér()
        {
            InitializeComponent();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Infirmiér_Load(object sender, EventArgs e)
        {
            Sauvegarder.Visible = false;
            Précédent_2.Visible = false;
            Précédent_3.Visible = false;
            suivant_3.Visible = false;
            Précédent_1.Visible = false;
            suivant_2.Visible = false;
            infopresonnelles infoprs = new infopresonnelles();
            addUserControl(infoprs);
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    // ...
                }
            }
           
        }

        

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            if (suivant_1.CanSelect)
            {

                Coordonnées con = new Coordonnées();
                addUserControl(con);
                suivant_2.Visible = true;
                suivant_1.Visible = false;
                Sauvegarder.Visible = false;
                Précédent_1.Visible = true;
                guna2Shapes1.FillColor= Color.FromArgb(0, 158, 251);
                guna2Shapes6.FillColor = Color.FromArgb(0, 158, 251);
                label5.BackColor = Color.FromArgb(0, 158, 251);
                label5.ForeColor = Color.FromArgb(255, 255, 255);
                /*
                label8.ForeColor = Color.FromArgb(0, 158, 251);
                */
               

                guna2Shapes5.BorderColor = Color.FromArgb(0, 158, 251);
                

            }

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (suivant_2.CanSelect)
            {
                Scolarité sco = new Scolarité();
                addUserControl(sco);
                Précédent_1.Visible = false;
                Précédent_2.Visible = true;
                Précédent_3.Visible = false;
                suivant_3.Visible = true;
                suivant_2.Visible = false;
                Sauvegarder.Visible = false;
                guna2Shapes5.FillColor = Color.FromArgb(0, 158, 251);
                guna2Shapes8.FillColor = Color.FromArgb(0, 158, 251);
                label8.BackColor = Color.FromArgb(0, 158, 251);
                label8.ForeColor = Color.FromArgb(255, 255, 255);
                label7.ForeColor = Color.FromArgb(0, 158, 251);

                guna2Shapes4.BorderColor = Color.FromArgb(0, 158, 251);
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (Précédent_1.CanSelect)
            {
                infopresonnelles infoprs = new infopresonnelles();
                addUserControl(infoprs);
                Précédent_1.Visible = false;
                Précédent_2.Visible = false;
                Précédent_3.Visible = false;
                suivant_3.Visible = false;
                suivant_2.Visible = false;
                suivant_1.Visible = true;
                Sauvegarder.Visible = false;
                //////////////////////
                guna2Shapes1.FillColor = Color.FromArgb(255,255, 255);
                guna2Shapes6.FillColor = Color.FromArgb(224, 224, 224);
                label5.BackColor = Color.FromArgb(255, 255, 255);
                label5.ForeColor = Color.FromArgb(0, 158, 251);
                ///////////////////
                ///
                guna2Shapes5.FillColor = Color.FromArgb(0, 158, 251);
                label8.BackColor = Color.FromArgb(0, 158, 251);
                label8.ForeColor = Color.FromArgb(255, 255, 255);
                guna2Shapes5.ForeColor = Color.FromArgb(0, 158, 251);
                
                

            }

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (Précédent_2.CanSelect)
            {
                Coordonnées con = new Coordonnées();
                addUserControl(con);
                Précédent_3.Visible = false;
                Précédent_1.Visible = true;
                Précédent_2.Visible = false;
                suivant_3.Visible = false;
                suivant_1.Visible = false;
                suivant_2.Visible = true;
                Sauvegarder.Visible = false;
                //////
                guna2Shapes4.FillColor = Color.FromArgb(0, 158, 251);
                label7.BackColor = Color.FromArgb(0, 158, 251);
                label7.ForeColor = Color.FromArgb(255, 255, 255);
                guna2Shapes4.ForeColor = Color.FromArgb(0, 158, 251);
                guna2Shapes5.BorderColor = Color.FromArgb(0, 158, 251);
                guna2Shapes5.BackColor = Color.FromArgb(255, 255, 255);
                guna2Shapes5.FillColor = Color.FromArgb(255, 255, 255);

                label8.ForeColor= Color.FromArgb(0, 158, 251);
                label8.BackColor = Color.FromArgb(255, 255, 255);



            }

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (Précédent_3.CanSelect)
            {
                Scolarité con = new Scolarité();
                addUserControl(con);
                suivant_1.Visible = false;
                suivant_2.Visible = true;
                Précédent_1.Visible = false;
                Précédent_2.Visible = true;
                Précédent_3.Visible = false;
                suivant_3.Visible = false;
                Sauvegarder.Visible = false;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes6_Click(object sender, EventArgs e)
        {

        }

        private void suivant_3_Click(object sender, EventArgs e)
        {
            if (suivant_3.CanSelect)
            {
                Inscription ins = new Inscription();
                addUserControl(ins);
                suivant_1.Visible = false;
                suivant_2.Visible = false;
                Précédent_1.Visible = false;
                Précédent_2.Visible = false;
                Précédent_3.Visible = true;
                suivant_3.Visible = false;
                Sauvegarder.Visible = true;
                guna2Shapes4.FillColor = Color.FromArgb(0, 158, 251);
                guna2Shapes7.FillColor = Color.FromArgb(0, 158, 251);
                /////
                label7.BackColor = Color.FromArgb(0, 158, 251);
                label7.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Sauvegarder_Click(object sender, EventArgs e)
        {
            guna2Shapes3.FillColor = Color.FromArgb(0, 158, 251);
            label6.BackColor = Color.FromArgb(0, 158, 251);
            label6.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
