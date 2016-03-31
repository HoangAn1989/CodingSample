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
        private SqlDataAdapter myAdapter;
        DataTable dataTable;
        private SqlCommand myCommand;
        private int index;
        public Manage()
        {
            InitializeComponent();
            
        }
        DataTable bang = new DataTable();
        private void Manage_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            lbUser.Text = userName;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();

            String str = "Select * From QUESTION as qt, ANSWER_1 as a1, ANSWER_2 as a2, ANSWER_3 as a3 Where qt.ID_QUESTION = a1.IDQUESTION and qt.ID_QUESTION = a2.IDQUESTION and qt.ID_QUESTION = a3.IDQUESTION ";
            myAdapter = new SqlDataAdapter(str, cnn);
            dataTable = new DataTable();
            myAdapter.Fill(dataTable);

            //dataGridView1.DataSource = dt;
            //bang = dt;


            foreach (DataRow dataRow in dataTable.Rows)
            {
                lbListQuestion.Items.Add("Question: " + dataRow["CONTENT_QUESTION"]);
                lbListQuestion.Items.Add("     - " + dataRow["ANSWER1"]);
                lbListQuestion.Items.Add("     - " + dataRow["ANSWER2"]);
                lbListQuestion.Items.Add("     - " + dataRow["ANSWER3"]);
            }

            this.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text +"' Where ID_QUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "' Where IDQUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER1 = '" + tbAnswer2.Text + "' Where IDQUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER1 = '" + tbAnswer3.Text + "' Where IDQUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();
            cnn.Close();
        }


        private void btSelect_Click(object sender, EventArgs e)
        {
            index = lbListQuestion.SelectedIndex;
            index = index / 4;
            DataRow targetRow = dataTable.Rows[index];
            tbQuestion.Text = targetRow["CONTENT_QUESTION"].ToString();
            tbAnswer1.Text = targetRow["ANSWER1"].ToString();
            tbAnswer2.Text = targetRow["ANSWER2"].ToString();
            tbAnswer3.Text = targetRow["ANSWER3"].ToString();
            Application.DoEvents();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            myCommand = new SqlCommand("delete from ANSWER_1 where IDQUESTION = '"+ index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from ANSWER_2 where IDQUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from ANSWER_3 where IDQUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from QUESTION where ID_QUESTION = '" + index, cnn);            
            myCommand.ExecuteNonQuery();
            cnn.Close();
            autoSortID();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int count = countRowQuestion();
            count++;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            myCommand = new SqlCommand("insert into QUESTION (ID_QUESTION,CONTENT_QUESTION) values('" + count +"','" + tbQuestion.Text + "')", cnn);
            cnn.Open();
            myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien
            cnn.Close();
            loadData();
        }
        
        private int countRowQuestion()
        {
            int count = 0;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            String str = "Select * From QUESTION";
            myAdapter = new SqlDataAdapter(str, cnn);
            dataTable = new DataTable();
            myAdapter.Fill(dataTable);
            count = dataTable.Rows.Count;
            return count;
        }

        private void autoSortID()
        {
            int count = 0;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            String str = "Select * From QUESTION";
            myAdapter = new SqlDataAdapter(str, cnn);
            dataTable = new DataTable();
            myAdapter.Fill(dataTable);
            cnn.Close();
            count = dataTable.Rows.Count;
            for(int i=1; i<=count; i++)
            {
                int iRow = (int)dataTable.Rows[i][0];
                if (iRow != i) 
                {
                    cnn.Open();
                    myCommand = new SqlCommand("Update QUESTION Set ID_QUESTION = '" + i + "' Where ID_QUESTION = '" + iRow, cnn);                    
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_1 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow, cnn);                    
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_2 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow, cnn);
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_3 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow, cnn);
                    myCommand.ExecuteNonQuery();

                    cnn.Close();
                }
            }
        }
        
    }
}
