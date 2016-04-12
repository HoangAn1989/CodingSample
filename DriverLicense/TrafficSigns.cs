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
using System.IO;
using System.Drawing.Imaging;

namespace DriverLicense
{
    public partial class TrafficSigns : Form
    {
        private ArrayList idSiqnList;
        private ArrayList realSignList;

        private static int amountSign = 10;

        public static Random _Random = new Random();

        private string[] contentSignList;

        private int idSign;
        private int _count;
        private int indexCbbSign;
        private string flag;
        private int totalSignAnswer;

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
                //contentSignList[j] = getSign(getIdSign);
                idSiqnList.Remove(numberRandom);
                cbbSigns.Items.Add(j + 1);
            }
            cbbSigns.SelectedIndex = 0;
            showContentSign();
            btnSignNext.Visible = true;
            llbSignSkip.Visible = true;
        }

        private void TrafficSigns_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showContentSign()
        {
            _count = cbbSigns.SelectedIndex;
            idSign = (int)realSignList[_count];
            tbSigns.Text = getSign(idSign);

            cbSign1.Text = getAnswerSign1(idSign);
            cbSign2.Text = getAnswerSign2(idSign);
            cbSign3.Text = getAnswerSign3(idSign);
            flag = getFlag(idSign);
            getImageSign(idSign);
            
        }

        private string getSign(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            string content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select QUESTIONSIGN from TRAFFICSIGN where ID_SIGN = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;            
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }

        private string getAnswerSign1(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            string content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER1 from TRAFFICSIGN where ID_SIGN = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }

        private string getAnswerSign2(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            string content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER2 from TRAFFICSIGN where ID_SIGN = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }

        private string getAnswerSign3(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            string content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER2 from TRAFFICSIGN where ID_SIGN = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }

        private string getFlag(int id)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            string content;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select FLAG from TRAFFICSIGN where ID_SIGN = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn;
            content = command.ExecuteScalar().ToString();
            conn.Close();
            return content;
        }

        private void getImageSign(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT SIGN FROM TRAFFICSIGN WHERE ID_SIGN ='" + id +"'", conn);
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "TRAFFICSIGN");
                int c = ds.Tables["TRAFFICSIGN"].Rows.Count;

                if (c > 0)
                {   //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["TRAFFICSIGN"].Rows[c - 1]["SIGN"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pbSign.Image = Image.FromStream(stmBLOBData);                    
                }
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

                
        private void cbbSigns_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetAll();
            indexCbbSign = cbbSigns.SelectedIndex;
            idSign = (int)realSignList[indexCbbSign];
            _count = indexCbbSign + 1;
            tbSigns.Text = getSign(idSign);
            cbSign1.Text = getAnswerSign1(idSign);
            cbSign2.Text = getAnswerSign2(idSign);
            cbSign3.Text = getAnswerSign3(idSign);
            flag = getFlag(idSign);
            getImageSign(idSign);
        }

        private void resetAll()
        {
            tbSigns.Text = "";
            cbSign1.Text = "";
            cbSign2.Text = "";
            cbSign3.Text = "";
            cbSign1.Checked = false;
            cbSign2.Checked = false;
            cbSign3.Checked = false;
        }

        private void btnSignNext_Click(object sender, EventArgs e)
        {
            if(_count < amountSign)
            {
                cbbSigns.SelectedIndex = _count;
                processNext_Click();
            }
        }

        private void processNext_Click()
        {
            int index = _count - 2;
            if(cbSign1.Checked == true)
            {
                
                if(flag == "1")
                {
                    totalSignAnswer++;
                    showContentSign();
                }
                else
                {
                    showContentSign();
                }
            }
            else if(cbSign2.Checked == true)
            {
                if (flag == "2")
                {
                    totalSignAnswer++;
                    showContentSign();
                }
                else
                {
                    showContentSign();
                }
            }
            else if(cbSign3.Checked == true)
            {
                if (flag == "3")
                {
                    totalSignAnswer++;
                    showContentSign();
                }
                else
                {
                    showContentSign();
                }
            }
        }

        private void llbSignSkip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        

    }
}
