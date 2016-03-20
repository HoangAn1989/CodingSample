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
        public ArrayList contentQuestionList = new ArrayList(amountQuestion);
        public ArrayList contetnRightAnswerList = new ArrayList(amountQuestion);
        public ArrayList contentWrongAnswerList = new ArrayList(amountQuestion);

        //combobox
        public int indexCombobox = 0;

        public Main()
        {
            InitializeComponent();
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();            
        }
        private void connect()
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
        }



        private void button2_Click(object sender, EventArgs e)
        {            
            pnTest.Visible = true;
            btnStart.Visible = false;
            btnNext.Visible = true;
            llbSkip.Visible = true;
            pnResult.Visible = false;
            getAllQuestion();
            cbbNumber.SelectedIndex = 0;
            displayContent();
            
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
            for(int j=0; j<25; j++)
            {
                int numberRandom = _Random.Next(idQuestionList.Count);
                getID = (int)idQuestionList[numberRandom];
                realTestList.Add(getID);
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
            command.CommandText = "Select FLAG from ANSWER_1 where IDQUESTION = @id";
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
            command.CommandText = "Select FLAG from ANSWER_2 where IDQUESTION = @id";
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
            command.CommandText = "Select FLAG from ANSWER_3 where IDQUESTION = @id";
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

        private void displayContent()
        {
            _count = cbbNumber.SelectedIndex;
            idQuestion = (int)realTestList[_count];            
            tbQuestion.Text = getQuestion(idQuestion);

            //Add question to list
            contentQuestionList.Insert(_count,tbQuestion.Text);
            string rightAnswer = getRightAnswer(idQuestion);
            contetnRightAnswerList.Insert(_count,rightAnswer);

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
            if (rdbAnswer1.Checked == true)
            {
                contentWrongAnswerList.Insert(_count - 1, rdbAnswer1.Text);            
                if (flag1 == 1)
                {
                    totalRightAnswer++;
                    displayContent();
                }
                else
                {
                    displayContent();
                }                
            }
            else if (rdbAnswer2.Checked == true)
            {
                contentWrongAnswerList.Insert(_count - 1, rdbAnswer1.Text);
                if (flag2 == 1)
                {
                    totalRightAnswer++;
                    displayContent();
                }
                else
                {
                    displayContent();
                }               
            }
            else if (rdbAnswer3.Checked == true)
            {
                contentWrongAnswerList.Insert(_count - 1, rdbAnswer1.Text);
                if (flag2 == 1)
                {
                    totalRightAnswer++;
                    displayContent();
                }
                else
                {
                    displayContent();
                }                
            }
            else
            {
                displayContent();
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
                processNextClick();
                pnTest.Visible = false;
                tbQuestion.Text = "";
                rdbAnswer1.Text = "";
                rdbAnswer2.Text = "";
                rdbAnswer3.Text = "";
                btnNext.Visible = false;
                llbSkip.Visible = false;
                pnResult.Visible = true;
            }
            rdbAnswer1.Checked = false;
            rdbAnswer2.Checked = false;
            rdbAnswer3.Checked = false;
        }

        private void llbSkip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            if (_count < 25)
            {
                cbbNumber.SelectedIndex = _count;
                displayContent();
                
                if (_count == 25)
                {
                    llbSkip.Visible = false;
                }
            }
            else if (_count == 25)
            {                
                pnTest.Visible = false;
                tbQuestion.Text = "";
                rdbAnswer1.Text = "";
                rdbAnswer2.Text = "";
                rdbAnswer3.Text = "";
                btnNext.Visible = false;
                llbSkip.Visible = false;
                pnResult.Visible = true;
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
            
        }       

        
        
    }
}
