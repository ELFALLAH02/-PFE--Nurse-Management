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
        public void RemplierComFiliére()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Filiére", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Filiére");
            guna2ComboBox2.DataSource = ClassVrariables.ds.Tables["Filiére"];
            guna2ComboBox2.DisplayMember = "Filiére_lable";
            guna2ComboBox2.ValueMember = "idF";
        }
        public void RemplierComOption_Filiére()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Option_Filiére", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Option_Filiére");
            guna2ComboBox3.DataSource = ClassVrariables.ds.Tables["Option_Filiére"];
            guna2ComboBox3.DisplayMember = "Option_lable";
            guna2ComboBox3.ValueMember = "idO";
        }

        public void RemplierComSemestre()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Semestre", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Semestre");
            guna2ComboBox1.DataSource = ClassVrariables.ds.Tables["Semestre"];
            guna2ComboBox1.DisplayMember = "S_label";
            guna2ComboBox1.ValueMember = "idS";
        }

        public void RemplierDtagridVie()
        {
            ClassVrariables.cmd = new SqlCommand("select s.Nom,s.Prénom,s.CIN,s.Massar ,s.Ninscription as'N°Inscription'  from Coordonnées c inner join Infirmiers s on c.CIN=s.CIN inner join Scolarité sc on s.CIN=sc.CIN inner join Inscription i on i.CIN=s.CIN", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Infirmiers");
            guna2DataGridView6.DataSource = ClassVrariables.ds.Tables["Infirmiers"];
        }
        public Infirmiers()
        {
            InitializeComponent();
        }

        private void Infirmiers_Load(object sender, EventArgs e)
        {
            // panel1.Visible = false;
            RemplierComFiliére();
            RemplierComOption_Filiére();
            RemplierComSemestre();

            RemplierDtagridVie();
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
