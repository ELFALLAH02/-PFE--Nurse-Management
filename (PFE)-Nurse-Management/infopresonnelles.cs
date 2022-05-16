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
    public partial class infopresonnelles : UserControl
    {
       
        public infopresonnelles()
        {
            InitializeComponent();
        }

        public static string CIN;
        public void RemplierComSexe()
        {
            ClassVrariables.cmd = new SqlCommand("select * from sexe", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "sexe");
            guna2ComboBox1.DataSource = ClassVrariables.ds.Tables["sexe"];
            guna2ComboBox1.DisplayMember = "sex";
        }

        public void RemplierComNationalit()
        {
            ClassVrariables.cmd = new SqlCommand("select * from Nationalit", ClassVrariables.ctn);
            ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
            ClassVrariables.ds = new DataSet();
            ClassVrariables.da.Fill(ClassVrariables.ds, "Nationalit");
            guna2ComboBox3.DataSource = ClassVrariables.ds.Tables["Nationalit"];
            guna2ComboBox3.DisplayMember = "Country";
            guna2ComboBox3.ValueMember = "idcon";
        }

        private void infopresonnelles_Load(object sender, EventArgs e)
        {
            RemplierComSexe();
            RemplierComNationalit();



        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          

        }

        private void kryptonRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {

                ClassVrariables.cmd = new SqlCommand("select * from Infirmiers", ClassVrariables.ctn);
                ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
                ClassVrariables.ds = new DataSet();
                ClassVrariables.da.Fill(ClassVrariables.ds, "Infirmiers");

                DataTable dt;
                dt = ClassVrariables.ds.Tables["Infirmiers"];
                DataRow li = dt.NewRow();
                li[0] = guna2TextBox4.Text;
                CIN = guna2TextBox4.Text;
                li[1] = guna2TextBox1.Text;
                li[2] = guna2TextBox2.Text;
                li[3] = guna2DateTimePicker1.Value;
                li[4] = guna2TextBox3.Text;
                li[5] = guna2TextBox6.Text;
                //li[6] = inf.guna2TextBox4.Text;
                li[7] = guna2ComboBox1.Text;
                li[8] = guna2ComboBox3.SelectedValue;
                li[9] = guna2TextBox6.Text + guna2TextBox4.Text;
                dt.Rows.Add(li);

                ClassVrariables.cb = new SqlCommandBuilder(ClassVrariables.da);
                ClassVrariables.da.Update(ClassVrariables.ds, "Infirmiers");
            }
        }
    }
}
