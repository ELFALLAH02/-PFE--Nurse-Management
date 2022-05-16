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
    public partial class Coordonnées : UserControl
    {
        
        public Coordonnées()
        {
            InitializeComponent();
        }

        private void Coordonnées_Load(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {


                ClassVrariables.cmd = new SqlCommand("select * from Coordonnées", ClassVrariables.ctn);
                ClassVrariables.da = new SqlDataAdapter(ClassVrariables.cmd);
                ClassVrariables.ds = new DataSet();
                ClassVrariables.da.Fill(ClassVrariables.ds, "Coordonnées");

                DataTable dt;
                dt = ClassVrariables.ds.Tables["Coordonnées"];
                DataRow li = dt.NewRow();
                li[0] = infopresonnelles.CIN;
                li[1] = guna2TextBox1.Text;
                li[2] = guna2TextBox2.Text;
                li[3] = guna2TextBox4.Text;
                dt.Rows.Add(li);
                ClassVrariables.cb = new SqlCommandBuilder(ClassVrariables.da);
                ClassVrariables.da.Update(ClassVrariables.ds, "Coordonnées");
            }
        }
    }
}
