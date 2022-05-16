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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
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
        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Infirmiér infirmiér = new Add_Infirmiér();
            addUserControl(infirmiér);
        }
    }
}
