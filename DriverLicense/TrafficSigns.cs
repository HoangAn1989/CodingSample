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
    public partial class TrafficSigns : Form
    {
        private ArrayList idSiqnList;
        private ArrayList realSignList;

        private static int amountSign = 10;

        public static Random _Random = new Random();

        private string[] contentSignList;

        public TrafficSigns()
        {
            InitializeComponent();
        }

        private void TrafficSigns_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from TRAFFICSIGN", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int countRow = table.Rows.Count;
            idSiqnList = new ArrayList(countRow);
            for(int i=0; i<countRow; i++)
            {
                idSiqnList.Add(table.Rows[i][0]);
            }
            realSignList = new ArrayList(amountSign);
            int getIdSign;
            for(int j=0; j<amountSign; j++)
            {
                int numberRandom = _Random.Next(idSiqnList.Count);
                getIdSign = (int)idSiqnList[numberRandom];
                realSignList.Add(getIdSign);
                contentSignList[j] = getQuestion(getIdSign);
                idSiqnList.Remove(numberRandom);
                cbbSigns.Items.Add(j + 1);
            }

        }

        private void TrafficSigns_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private String getQuestion(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            String content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select CONTENT_QUESTION from TRAFFICSIGN where ID_QUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;
            
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }
    }
}
