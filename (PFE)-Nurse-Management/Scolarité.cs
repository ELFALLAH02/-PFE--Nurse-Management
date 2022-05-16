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
    public partial class Scolarité : UserControl
    {
        public Scolarité()
        {
            InitializeComponent();
        }
        public void RemplierComNationalitBac()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Nationalit", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Nationalit");
            guna2ComboBox3.DataSource = ClassVrariables.ds.Tables["Nationalit"];
            guna2ComboBox3.DisplayMember = "Country";
            guna2ComboBox3.ValueMember = "idcon";
        }

        public void RemplierComMention_bac()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Mention_bac", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Mention_bac");
            guna2ComboBox1.DataSource = ClassVrariables.ds.Tables["Mention_bac"];
            guna2ComboBox1.DisplayMember = "Mention_lable";
        }
        private void Scolarité_Load(object sender, EventArgs e)
        {
            RemplierComNationalitBac();
            RemplierComMention_bac() ;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {
                ClassVrariables.cmd = new SqlCommand("select * from Scolarité", ClassVrariables.ctn);
                ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
                ClassVrariables.ds = new DataSet();
                ClassVrariables.da.Fill(ClassVrariables.ds, "Scolarité");

                DataTable dt;
                dt = ClassVrariables.ds.Tables["Scolarité"];
                DataRow li = dt.NewRow();
                li[0] = infopresonnelles.CIN;
                li[1] =  guna2TextBox1.Text;
                li[2] = guna2TextBox4.Text;
                li[3] = guna2ComboBox3.SelectedValue;
                li[4] = guna2ComboBox1.Text;
                dt.Rows.Add(li);
                ClassVrariables.cb = new SqlCommandBuilder(ClassVrariables.da);
                ClassVrariables.da.Update(ClassVrariables.ds, "Scolarité");
            }
              
        }
    }
}
