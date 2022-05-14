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
         
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Infirmiers inf_inter = new Infirmiers();
            addUserControl(inf_inter);

        
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
