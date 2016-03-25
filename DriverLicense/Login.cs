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
using System.Collections;

namespace DriverLicense
{
    public partial class Login : Form
    {
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" || tbPassword.Text == "")   
            {
                MessageBox.Show("Please, Fill out Username & Password");
            }
            else
            {
                try
                {
                    cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
                }
                catch
                {

                }
            }
        }
    }
}
