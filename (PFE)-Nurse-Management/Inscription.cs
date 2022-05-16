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
    public partial class Inscription : UserControl
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void RemplierComFiliére()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Filiére", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Filiére");
            guna2ComboBox3.DataSource = ClassVrariables.ds.Tables["Filiére"];
            guna2ComboBox3.DisplayMember = "Filiére_lable";
            guna2ComboBox3.ValueMember = "idF";
        }

        public void RemplierComOption_Filiére()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Option_Filiére", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Option_Filiére");
            guna2ComboBox1.DataSource = ClassVrariables.ds.Tables["Option_Filiére"];
            guna2ComboBox1.DisplayMember = "Option_lable";
            guna2ComboBox1.ValueMember = "idO";
        }

        public void RemplierComSemestre()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Semestre", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Semestre");
            guna2ComboBox2.DataSource = ClassVrariables.ds.Tables["Semestre"];
            guna2ComboBox2.DisplayMember = "S_label";
            guna2ComboBox2.ValueMember = "idS";
        }
        private void Inscription_Load(object sender, EventArgs e)
        {
            RemplierComFiliére();
            RemplierComOption_Filiére();
            RemplierComSemestre();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {
                ClassVrariables.cmd = new SqlCommand("select * from Inscription", ClassVrariables.ctn);
                ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
                ClassVrariables.ds = new DataSet();
                ClassVrariables.da.Fill(ClassVrariables.ds, "Inscription");

                DataTable dt;
                dt = ClassVrariables.ds.Tables["Inscription"];
                DataRow li = dt.NewRow();
                li[0] = infopresonnelles.CIN;
                li[1] = guna2ComboBox3.SelectedValue;
                li[2] = guna2ComboBox1.SelectedValue;
                li[3] = guna2ComboBox2.SelectedValue;
                li[4] = guna2TextBox2.Text;
                li[5] = guna2TextBox6.Text;
                dt.Rows.Add(li);
                ClassVrariables.cb = new SqlCommandBuilder(ClassVrariables.da);
                ClassVrariables.da.Update(ClassVrariables.ds, "Inscription");
                
            }
        }
    }
}
