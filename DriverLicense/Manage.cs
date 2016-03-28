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
    public partial class Manage : Form
    {
        public String userName;
        SqlConnection cnn;
        public Manage()
        {
            InitializeComponent();
            lbUser.Text = userName;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
        }
        
    }
}
