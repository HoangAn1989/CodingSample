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
    public partial class Main : Form
    {
        SqlConnection cnn;
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        public static Random _Random = new Random();
        public ArrayList idQuestionList;
        public ArrayList realTestList;
        public int _count = 0;
        public static int amountQuestion = 25;
        public int totalRightAnswer = 0;

        public int idQuestion = 0;
        public string answer1, answer2, answer3 = "";
        public int flag1, flag2, flag3 = 0;

        //result
        public string[] contentQuestionList;
        public string[] contetnRightAnswerList;
        public string[] contentWrongAnswerList;

        //combobox
        public int indexCombobox = 0;

        //Admin
        public string userName = "";

        public Main()
        {
            InitializeComponent();
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            if(userName != "")
            {
                
                
            }
            
        }
        public void showManageTool()
        {
            ManageToolStripMenuItem.Visible = true;
        }

        public void hideAdminTool()
        {
            adminToolStripMenuItem.Visible = false;
        }
        private void connect()
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
        }      
        

        public void getAllQuestion()
        {
            connect();
            adapter = new SqlDataAdapter("Select * from QUESTION", cnn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int countRow = table.Rows.Count;
            idQuestionList = new ArrayList(countRow);
            for(int i=0; i<countRow; i++)
            {                
                idQuestionList.Add(table.Rows[i][0]);
                
            }
            realTestList = new ArrayList(amountQuestion);
            int getID;
            for (int j = 0; j < amountQuestion; j++)
            {
                int numberRandom = _Random.Next(idQuestionList.Count);
                getID = (int)idQuestionList[numberRandom];
                realTestList.Add(getID);
                contentQuestionList[j] = getQuestion(getID);
                idQuestionList.Remove(numberRandom);
                cbbNumber.Items.Add(j+1);

            }
        }

        private String getQuestion(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            String content;            
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select CONTENT_QUESTION from QUESTION where ID_QUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            content = command.ExecuteScalar().ToString();
            cnn.Close();
            return content;
        }

        private String getAnswer_1(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            String answer;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER1 from ANSWER_1 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            answer = command.ExecuteScalar().ToString();
            cnn.Close();
            return answer;
        }

        private int flagAnswer_1(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            int flag;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select FLAG1 from ANSWER_1 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            flag = (int) command.ExecuteScalar();
            cnn.Close();
            return flag;
        }

        private String getAnswer_2(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            String answer;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER2 from ANSWER_2 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            answer = command.ExecuteScalar().ToString();
            cnn.Close();
            return answer;
        }

        private int flagAnswer_2(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            int flag;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select FLAG2 from ANSWER_2 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            flag = (int) command.ExecuteScalar();
            cnn.Close();
            return flag;
        }

        private String getAnswer_3(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            String answer;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ANSWER3 from ANSWER_3 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            answer = command.ExecuteScalar().ToString();
            cnn.Close();
            return answer;
        }

        private int flagAnswer_3(int id)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            int flag;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select FLAG3 from ANSWER_3 where IDQUESTION = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = cnn;
            cnn.Open();
            flag = (int) command.ExecuteScalar();
            cnn.Close();
            return flag;
        }
       
        private string getRightAnswer(int id)
        {
            string rightanswer = "";
            string _answer1 = getAnswer_1(id);
            int _flag1 = flagAnswer_1(id);
            string _answer2 = getAnswer_2(id);
            int _flag2 = flagAnswer_2(id);
            string _answer3 = getAnswer_3(id);
            int _flag3 = flagAnswer_3(id);
            if(_flag1 == 1)
            {
                rightanswer = _answer1;                
            }
            else if(_flag2 == 1)
            {
                rightanswer = _answer2;
            }
            else if(_flag3 == 1)
            {
                rightanswer = _answer3;
            }
            return rightanswer;
        }

        private void showContent()
        {
            _count = cbbNumber.SelectedIndex;
            idQuestion = (int)realTestList[_count];            
            tbQuestion.Text = getQuestion(idQuestion);
            
            //Add question to list
            contentQuestionList[_count] = tbQuestion.Text;
            string rightAnswer = getRightAnswer(idQuestion);
            contetnRightAnswerList[_count] = rightAnswer;

            //Show Answer
            answer1 = getAnswer_1(idQuestion);
            flag1 = flagAnswer_1(idQuestion);
            rdbAnswer1.Text = answer1;
            answer2 = getAnswer_2(idQuestion);
            flag2 = flagAnswer_2(idQuestion);
            rdbAnswer2.Text = answer2;
            answer3 = getAnswer_3(idQuestion);
            flag3 = flagAnswer_3(idQuestion);
            rdbAnswer3.Text = answer3;
            _count++;
            
        }

        private void processNextClick()
        {

            int index = _count - 2;
            if (rdbAnswer1.Checked == true)
            {
                contentWrongAnswerList[index] = rdbAnswer1.Text;            
                if (flag1 == 1)
                {
                    totalRightAnswer++;
                    showContent();
                }
                else
                {
                    showContent();
                }                
            }
            else if (rdbAnswer2.Checked == true)
            {
                contentWrongAnswerList[index] = rdbAnswer2.Text;
                if (flag2 == 1)
                {
                    totalRightAnswer++;
                    showContent();
                }
                else
                {
                    showContent();
                }               
            }
            else if (rdbAnswer3.Checked == true)
            {
                contentWrongAnswerList[index] = rdbAnswer3.Text;
                if (flag2 == 1)
                {
                    totalRightAnswer++;
                    showContent();
                }
                else
                {
                    showContent();
                }                
            }
            else
            {
                showContent();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {            
            if(_count < 25)
            {
                cbbNumber.SelectedIndex = _count;
                processNextClick();
                
                if (_count == 25)
                {
                    llbSkip.Visible = false;
                }
            }
            else if(_count == 25)
            {
                _count = 26;
                processNextClick();
                pnTest.Visible = false;
                tbQuestion.Text = "";
                rdbAnswer1.Text = "";
                rdbAnswer2.Text = "";
                rdbAnswer3.Text = "";
                btnNext.Visible = false;
                llbSkip.Visible = false;
                pnResult.Visible = true;
                lbxResult.Visible = true;
                lbl1.Visible = true;
                lblResult.Visible = true;
                showResult();
            }
            rdbAnswer1.Checked = false;
            rdbAnswer2.Checked = false;
            rdbAnswer3.Checked = false;
        }

        private void llbSkip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {                       
            cbbNumber.SelectedIndex = _count;
            showContent();
              
            if (_count == 25)
            {
                llbSkip.Visible = false;
            }     
            rdbAnswer1.Checked = false;
            rdbAnswer2.Checked = false;
            rdbAnswer3.Checked = false;
        }

        private void cbbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexCombobox = cbbNumber.SelectedIndex;
            idQuestion = (int)realTestList[indexCombobox];
            _count = indexCombobox + 1; 
            
            tbQuestion.Text = getQuestion(idQuestion);
            answer1 = getAnswer_1(idQuestion);
            flag1 = flagAnswer_1(idQuestion);
            rdbAnswer1.Text = answer1;
            answer2 = getAnswer_2(idQuestion);
            flag2 = flagAnswer_2(idQuestion);
            rdbAnswer2.Text = answer2;
            answer3 = getAnswer_3(idQuestion);
            flag3 = flagAnswer_3(idQuestion);
            rdbAnswer3.Text = answer3;

            if (indexCombobox < 24)
            {
                llbSkip.Visible = true;
            }
           
        }       

        private void showResult()
        {
            lblResult.Text = totalRightAnswer.ToString() + "/25"; 
            for (int i = 0; i < amountQuestion; i++ )
            {
                int STT = i + 1;
                lbxResult.Items.Add("Question " + STT + " : " + contentQuestionList[i]);
                //lbxResult.Items.Add(contentQuestionList[i]);
                lbxResult.Items.Add("Your Answer :");
                if (contentWrongAnswerList[i] == null)
                {
                    lbxResult.Items.Add("No Answer :");
                }
                else
                {
                    lbxResult.Items.Add(contentWrongAnswerList[i]);
                }
                
                lbxResult.Items.Add("Right Answer :");
                lbxResult.Items.Add(contetnRightAnswerList[i]);
                lbxResult.Items.Add(" ");
            }
                
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnLogin.Visible = true;
            btnStart.Visible = false;
            pnStarting.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String User = tbUsername.Text;

            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please, Fill out Username & Password");
            }
            else
            {
                try
                {
                    cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select * from ADMINISTRATOR where USER_ID = @id and USER_PASS = @pass";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", tbUsername.Text);
                    command.Parameters.AddWithValue("@pass", tbPassword.Text);
                    command.Connection = cnn;
                    cnn.Open();
                    User = command.ExecuteScalar().ToString();
                    cnn.Close();

                    userName = User;
                    pnLogin.Visible = false;
                    ManageToolStripMenuItem.Visible = true;
                    adminToolStripMenuItem.Visible = false;
                    pnTest.Visible = false;
                    pnResult.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Please, Double check your User & Password.");
                    return;
                }
            }
        }

        private void ManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage mn = new Manage();
            mn.userName = userName;
            mn.Show();

        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.Visible = false;
            pnTest.Visible = true;
            btnStart.Visible = true;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGreen;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LimeGreen;
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.DarkGreen;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.LimeGreen;

        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.DarkGreen;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.LimeGreen;
        }

        private void llbSkip_MouseHover(object sender, EventArgs e)
        {
            llbSkip.LinkColor = Color.Black;
        }

        private void llbSkip_MouseLeave(object sender, EventArgs e)
        {
            llbSkip.LinkColor = Color.Blue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cbQuestion.Checked == true)
            {
                pnStarting.Visible = false;
                pnTest.Visible = true;
                btnStart.Visible = false;
                btnNext.Visible = true;
                llbSkip.Visible = true;
                pnResult.Visible = false;
                contentQuestionList = new string[amountQuestion];
                contetnRightAnswerList = new string[amountQuestion];
                contentWrongAnswerList = new string[amountQuestion];
                getAllQuestion();
                cbbNumber.SelectedIndex = 0;
                showContent();
            }
            else if(cbTrafficSigns.Checked == true)
            {
                this.Hide();
                TrafficSigns ts = new TrafficSigns();
                ts.Show();
            }
            
        }
        
        
    }
}
