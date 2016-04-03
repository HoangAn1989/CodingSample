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
        DataTable userTable;
        private SqlCommand myCommand;
        private int index;
        public Manage()
        {
            InitializeComponent();
            
        }
        DataTable bang = new DataTable();
        private void Manage_Load(object sender, EventArgs e)
        {
            loadQuestion();
            loadUSer();
        }

        private void loadQuestion()
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

            
        }

        private void loadUSer()
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            String str = "Select * From ADMINISTRATOR";
            myAdapter = new SqlDataAdapter(str, cnn);
            userTable = new DataTable();
            myAdapter.Fill(userTable);

            foreach (DataRow row in userTable.Rows)
            {
                lboxUser.Items.Add("UserName/PassWord: " + row["USER_ID"] + "/" + row["USER_PASS"]);
            }
            cnn.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            if(cbAnwser1.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '1' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER1 = '" + tbAnswer2.Text + "', FLAG2 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER1 = '" + tbAnswer3.Text + "', FLAG3 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();
            }else if(cbAnswer2.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER1 = '" + tbAnswer2.Text + "', FLAG2 = '1' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER1 = '" + tbAnswer3.Text + "', FLAG3 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();
            }else if (cbAnswer3.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER1 = '" + tbAnswer2.Text + "', FLAG2 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER1 = '" + tbAnswer3.Text + "', FLAG3 = '1' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("please, Stick one checkbox that is correct Answer");
            }
            cnn.Close();
            reset();
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
            if((int) targetRow["FLAG1"] == 1)
            {
                cbAnwser1.Checked = true;
            }
            else if((int) targetRow["FLAG2"] == 1)
            {
                cbAnswer2.Checked = true;
            }
            else if((int) targetRow["FLAG3"] == 1)
            {
                cbAnswer3.Checked = true;
            }
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
            reset();
            autoSortID();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int count = countRowQuestion();
            count++;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            
            if(cbAnwser1.Checked == true)
            {
                myCommand = new SqlCommand("insert into QUESTION (ID_QUESTION,CONTENT_QUESTION) values('" + count + "','" + tbQuestion.Text + "')", cnn);
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien

                myCommand = new SqlCommand("insert into ANSWER_1 (IDQUESTION,ANSWER1,FLAG1) values('" + count + "','" + tbAnswer1.Text + "','" + 1 + "')", cnn);                
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien

                myCommand = new SqlCommand("insert into ANSWER_2 (IDQUESTION,ANSWER2,FLAG2) values('" + count + "','" + tbAnswer2.Text + "','" + 0 + "')", cnn);
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien

                myCommand = new SqlCommand("insert into ANSWER_3 (IDQUESTION,ANSWER3,FLAG3) values('" + count + "','" + tbAnswer3.Text + "','" + 0 + "')", cnn);
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien
            }
            else if(cbAnswer2.Checked == true)
            {
                myCommand = new SqlCommand("insert into QUESTION (ID_QUESTION,CONTENT_QUESTION) values('" + count + "','" + tbQuestion.Text + "')", cnn);
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien

                myCommand = new SqlCommand("insert into ANSWER_1 (IDQUESTION,ANSWER1,FLAG1) values('" + count + "','" + tbAnswer1.Text + "','" + 0 + "')", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("insert into ANSWER_2 (IDQUESTION,ANSWER2,FLAG2) values('" + count + "','" + tbAnswer2.Text + "','" + 1 + "')", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("insert into ANSWER_3 (IDQUESTION,ANSWER3,FLAG3) values('" + count + "','" + tbAnswer3.Text + "','" + 0 + "')", cnn);
                myCommand.ExecuteNonQuery();
            }
            else if(cbAnswer3.Checked == true)
            {
                myCommand = new SqlCommand("insert into QUESTION (ID_QUESTION,CONTENT_QUESTION) values('" + count + "','" + tbQuestion.Text + "')", cnn);
                myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien

                myCommand = new SqlCommand("insert into ANSWER_1 (IDQUESTION,ANSWER1,FLAG1) values ('" + count + "','" + tbAnswer1.Text + "','" + 0 +"')", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("insert into ANSWER_2 (IDQUESTION,ANSWER2,FLAG2) values ('" + count + "','" + tbAnswer2.Text + "','" + 0 +"')", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("insert into ANSWER_3 (IDQUESTION,ANSWER3,FLAG3) values ('" + count + "','" + tbAnswer3.Text + "','" + 1 + "')", cnn);
                myCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("please, Stick one checkbox that is correct Answer");
            }
            
            cnn.Close();
            reset();
            loadQuestion();
        }

        private void reset()
        {
            tbQuestion.Text = "";
            tbAnswer1.Text = "";
            tbAnswer2.Text = "";
            tbAnswer3.Text = "";
            cbAnwser1.Checked = false;
            cbAnswer2.Checked = false;
            cbAnswer3.Checked = false;
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
            cnn.Close();
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

        private void btSelectUser_Click(object sender, EventArgs e)
        {
            DataRow targetRow = userTable.Rows[lboxUser.SelectedIndex];
            tbUser.Text = targetRow["USER_ID"].ToString();
            tbPass.Text = targetRow["USER_PASS"].ToString();
            tbUser.ReadOnly = true;
            Application.DoEvents();
        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            myCommand = new SqlCommand("Update ADMINISTRATOR Set USER_PASS = '" + tbPass.Text + "' Where USER_ID = '" + tbUser.Text, cnn);
            myCommand.ExecuteNonQuery();
            cnn.Close();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            myCommand = new SqlCommand("delete from ADMINISTRATOR where USER_ID = '" + tbUser.Text, cnn);
            myCommand.ExecuteNonQuery();
            cnn.Close();
        }

        private void btNewUser_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            myCommand = new SqlCommand("insert into ADMINISTRATOR (USER_ID,USER_PASS) values('" + tbUser.Text + "','" + tbPass.Text + "')", cnn);
            cnn.Open();
            myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien
            cnn.Close();
        }

        private void btUnSelect_Click(object sender, EventArgs e)
        {
            tbUser.ReadOnly = false;
        }

        
    }
}
