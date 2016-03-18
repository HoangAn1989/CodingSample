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
        public ArrayList questionList;
        public ArrayList realTest;
        public int _count = 0;
        public int totalRightAnswer = 0;
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
            int getIdQuestion;
            pnTest.Visible = true;
            btnStart.Visible = false;
            btnNext.Visible = true;
            llbSkip.Visible = true;
            getAllQuestion();
            getIdQuestion = (int) realTest[_count];
            _count++;
            tbQuestion.Text = getQuestion(getIdQuestion);
            string answer1 = getAnswer_1(getIdQuestion);
            int flag1 = flagAnswer_1(getIdQuestion);
            rdbAnswer1.Text = answer1;
            string answer2 = getAnswer_2(getIdQuestion);
            int flag2 = flagAnswer_2(getIdQuestion);
            rdbAnswer2.Text = answer2;
            string answer3 = getAnswer_3(getIdQuestion);
            int flag3 = flagAnswer_3(getIdQuestion);
            rdbAnswer3.Text = answer3;
        }      
        

        public void getAllQuestion()
        {
            connect();
            adapter = new SqlDataAdapter("Select * from QUESTION", cnn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int countRow = table.Rows.Count;
            questionList = new ArrayList(countRow);
            for(int i=0; i<countRow; i++)
            {                
                questionList.Add(table.Rows[i][0]);
                
            }
            
            realTest = new ArrayList(25);
            int getID;
            for(int j=0; j<25; j++)
            {
                int numberRandom = _Random.Next(questionList.Count);
                getID = (int)questionList[numberRandom];
                realTest.Add(getID);
                //questionList.Remove(numberRandom);
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
            return flag;
        }
       
        private string getRightAnswer(int id)
        {
            string rightanswer = "";
            string answer1 = getAnswer_1(id);
            int flag1 = flagAnswer_1(id);
            string answer2 = getAnswer_2(id);
            int flag2 = flagAnswer_2(id);
            string answer3 = getAnswer_3(id);
            int flag3 = flagAnswer_3(id);
            if(flag1 == 1)
            {
                rightanswer = answer1;                
            }
            else if(flag2 == 1)
            {
                rightanswer = answer2;
            }
            else if(flag3 == 1)
            {
                rightanswer = answer3;
            }
            return rightanswer;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_count < 25)
            {
                int getIdQuestion;
                
                getIdQuestion = (int)realTest[_count];
                _count++;
                tbQuestion.Text = getQuestion(getIdQuestion);
                string answer1 = getAnswer_1(getIdQuestion);
                int flag1 = flagAnswer_1(getIdQuestion);
                rdbAnswer1.Text = answer1;
                string answer2 = getAnswer_2(getIdQuestion);
                int flag2 = flagAnswer_2(getIdQuestion);
                rdbAnswer2.Text = answer2;
                string answer3 = getAnswer_3(getIdQuestion);
                int flag3 = flagAnswer_3(getIdQuestion);
                rdbAnswer3.Text = answer3;
            }
            else if(_count == 25)
            {
                pnTest.Visible = false;
                btnNext.Visible = false;
                llbSkip.Visible = false;
            }
        }
        
    }
}
