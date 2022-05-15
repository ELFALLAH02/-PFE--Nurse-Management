using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _PFE__Nurse_Management
{
   public class ClassVrariables
    {
        public static SqlConnection ctn = new SqlConnection("Data Source=.;Initial Catalog=Gestion_de_infirmier;Integrated Security=True");
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlCommandBuilder cb;
    }
}
