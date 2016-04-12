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
    public partial class Manage : Form
    {
        public String userName;
        SqlConnection cnn;
        private SqlDataAdapter myAdapter;
        DataTable dataTable;
        DataTable userTable;
        private SqlCommand myCommand;
        private int index;
        private string fileName;
        private int idSign;
        public Manage()
        {
            InitializeComponent();
            
        }
        DataTable bang = new DataTable();
        private void Manage_Load(object sender, EventArgs e)
        {
            loadQuestion();
            loadUSer();
            LoadSign();
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

            lbListQuestion.Items.Clear();
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
            lboxUser.Items.Clear();
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
            index++;
            if(cbAnswer1.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '1' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER2 = '" + tbAnswer2.Text + "', FLAG2 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER3 = '" + tbAnswer3.Text + "', FLAG3 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();
            }else if(cbAnswer2.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER2 = '" + tbAnswer2.Text + "', FLAG2 = '1' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER3 = '" + tbAnswer3.Text + "', FLAG3 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();
            }else if (cbAnswer3.Checked == true)
            {
                myCommand = new SqlCommand("Update QUESTION Set CONTENT_QUESTION = '" + tbQuestion.Text + "' Where ID_QUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_1 Set ANSWER1 = '" + tbAnswer1.Text + "', FLAG1 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_2 Set ANSWER2 = '" + tbAnswer2.Text + "', FLAG2 = '0' Where IDQUESTION = '" + index + "'", cnn);
                myCommand.ExecuteNonQuery();

                myCommand = new SqlCommand("Update ANSWER_3 Set ANSWER3 = '" + tbAnswer3.Text + "', FLAG3 = '1' Where IDQUESTION = '" + index + "'", cnn);
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


        private void btSelect_Click(object sender, EventArgs e)
        {
            cbAnswer1.Checked = false;
            cbAnswer2.Checked = false;
            cbAnswer3.Checked = false;
            index = lbListQuestion.SelectedIndex;
            index = index / 4;
            DataRow targetRow = dataTable.Rows[index];
            tbQuestion.Text = targetRow["CONTENT_QUESTION"].ToString();
            tbAnswer1.Text = targetRow["ANSWER1"].ToString();
            tbAnswer2.Text = targetRow["ANSWER2"].ToString();
            tbAnswer3.Text = targetRow["ANSWER3"].ToString();
            if((int) targetRow["FLAG1"] == 1)
            {
                cbAnswer1.Checked = true;
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
            index++;
            myCommand = new SqlCommand("delete from ANSWER_1 where IDQUESTION = '"+ index + "'", cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from ANSWER_2 where IDQUESTION = '" + index + "'", cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from ANSWER_3 where IDQUESTION = '" + index + "'", cnn);            
            myCommand.ExecuteNonQuery();

            myCommand = new SqlCommand("delete from QUESTION where ID_QUESTION = '" + index + "'", cnn);            
            myCommand.ExecuteNonQuery();
            cnn.Close();
            reset();
            
            loadQuestion();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int count = countRowQuestion();
            count++;
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            
            if(cbAnswer1.Checked == true)
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
            cbAnswer1.Checked = false;
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
                    myCommand = new SqlCommand("Update QUESTION Set ID_QUESTION = '" + i + "' Where ID_QUESTION = '" + iRow + "'", cnn);                    
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_1 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow + "'", cnn);                    
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_2 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow + "'", cnn);
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand("Update ANSWER_3 Set IDQUESTION = '" + i + "' Where IDQUESTION = '" + iRow + "'", cnn);
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
            myCommand = new SqlCommand("Update ADMINISTRATOR Set USER_PASS = '" + tbPass.Text + "' Where USER_ID = '" + tbUser.Text + "'", cnn);
            myCommand.ExecuteNonQuery();
            cnn.Close();
            loadUSer();
            resetUser();
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            cnn.Open();
            myCommand = new SqlCommand("delete from ADMINISTRATOR where USER_ID = '" + tbUser.Text + "'", cnn);
            myCommand.ExecuteNonQuery();
            cnn.Close();
            loadUSer();
            resetUser();
        }

        private void btNewUser_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            myCommand = new SqlCommand("insert into ADMINISTRATOR (USER_ID,USER_PASS) values('" + tbUser.Text + "','" + tbPass.Text + "')", cnn);
            cnn.Open();
            myCommand.ExecuteNonQuery();//ko tra ve chi thuc hien
            cnn.Close();
            loadUSer();
            resetUser();

        }

        private void btUnSelect_Click(object sender, EventArgs e)
        {
            tbUser.ReadOnly = false;
        }

        private void resetUser()
        {
            tbUser.Text = "";
            tbPass.Text = "";
        }

        private void Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //private void btChooseSign1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
        //        SqlCommand sqlCmd = new SqlCommand("INSERT INTO TRAFFICSIGN (SIGN1) VALUES (@BLOBData)", conn);
        //        String sBLOBFilePath = @"D:\Tulips.jpg";//Modify this path as needed.

        //        //Read jpg into file stream, and from there into Byte array.
        //        FileStream fsBLOBFile = new FileStream(sBLOBFilePath, FileMode.Open, FileAccess.Read);
        //        Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
        //        fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
        //        fsBLOBFile.Close();

        //        //Create parameter for insert command and add to SqlCommand object.
        //        SqlParameter prm = new SqlParameter("@BLOBData", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false,
        //                    0, 0, null, DataRowVersion.Current, bytBLOBData);
        //        sqlCmd.Parameters.Add(prm);

        //        //Open connection, execute query, and close connection.
        //        conn.Open();
        //        sqlCmd.ExecuteNonQuery();
        //        conn.Close();
        //        MessageBox.Show("File imported successfully into the database.");
        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message); }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
        //        conn.Open();

        //        //Retrieve BLOB from database into DataSet.
        //        SqlCommand sqlCmd = new SqlCommand("SELECT ID_SIGNS, SIGN1 FROM TRAFFICSIGN ", conn);
        //        SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
        //        DataSet ds = new DataSet();
        //        sqlDA.Fill(ds, "TRAFFICSIGN");
        //        int c = ds.Tables["TRAFFICSIGN"].Rows.Count;

        //        if (c > 0)
        //        {   //BLOB is read into Byte array, then used to construct MemoryStream,
        //            //then passed to PictureBox.
        //            Byte[] byteBLOBData = new Byte[0];
        //            byteBLOBData = (Byte[])(ds.Tables["TRAFFICSIGN"].Rows[c - 1]["SIGN1"]);
        //            MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
        //            pbSign1.Image = Image.FromStream(stmBLOBData);
        //            MessageBox.Show("File read from the database successfully.");
        //        }
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message); }
        //}
        
        private void btChooseSign2_Click(object sender, EventArgs e)
        {
            openFileDialogSign2.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|All Files (*.*)|*.*";
            if(openFileDialogSign2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbSign.ImageLocation = openFileDialogSign2.FileName;
                fileName = openFileDialogSign2.FileName;
                openFileDialogSign2.Dispose();
            }
        }
        byte[] imageData = null;
        private int AddSigns(int ID, string question, string filename, string answer1, string answer2, string answer3, int flag)
        {
            
            // Đọc file chuyển sang mảng
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }

            using (SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TRAFFICSIGN(ID_SIGN, QUESTIONSIGN, SIGN, ANSWER1, ANSWER2, ANSWER3, FLAG) values(@ID, @Question, @Sign, @Answer1, @Answer2, @Answer3, @Flag)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters["@Question"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@Sign", SqlDbType.Image);
                cmd.Parameters["@Sign"].Direction = ParameterDirection.Input;
                // Lưu trữ mảng byte vào cột Image
                cmd.Parameters["@Sign"].Value = imageData;
                cmd.Parameters.AddWithValue("@Answer1", answer1);
                cmd.Parameters.AddWithValue("@Answer2", answer2);
                cmd.Parameters.AddWithValue("@Answer3", answer3);
                cmd.Parameters.AddWithValue("@Flag", flag);                
                conn.Open();
                return cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int count = countSign();
            count++;
            string question = tbQuestionSign.Text;
            string answer1 = tbAnswerSign1.Text;
            string answer2 = tbAnswerSign2.Text;
            string answer3 = tbAnswerSign3.Text;
            int flag = 0;
            if(cbAnswerSign1.Checked == true)
            {
                flag = 1;
            }
            else if(cbAnswerSign2.Checked == true)
            {
                flag = 2;
            }
            else if (cbAnswerSign3.Checked == true) 
            {
                flag = 3;
            }
            int AS = AddSigns(count, question ,fileName,answer1,answer2,answer3,flag);
            if (AS > 0)
            {
                MessageBox.Show("OK");
                LoadSign();
                resetSign();
            }
            else MessageBox.Show("ERROR");
        }

        private int countSign()
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            int count = 0;
            SqlDataAdapter myAdapter = new SqlDataAdapter("Select * From TRAFFICSIGN", conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            count = table.Rows.Count;
            conn.Close();
            return count;
        }
        
        private void LoadSign()
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("Select * From TRAFFICSIGN", conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);  
            gridViewSign.DataSource = table;
        }

        /// <summary>
        /// This Function is convert byte to image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btUpdateSign_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            if(cbAnswerSign1.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Update TRAFFICSIGN Set ID_SIGN = '@ID', QUESTIONSIGN = '@Question', SIGN = '@Sign', ANSWER1 ='@Answer1', ANSWER2 = '@Answer2', ANSWER3 = '@Answer3', FLAG = '@Flag'" + "Where QUESTIONSIGN = '" + tbQuestionSign.Text + "'", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", idSign);
                cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Question", tbQuestionSign.Text);
                cmd.Parameters["@Question"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@Sign", SqlDbType.Image);
                cmd.Parameters["@Sign"].Direction = ParameterDirection.Input;                
                cmd.Parameters["@Sign"].Value = imageData;
                cmd.Parameters.AddWithValue("@Answer1", tbAnswerSign1.Text);
                cmd.Parameters.AddWithValue("@Answer2", tbAnswerSign2.Text);
                cmd.Parameters.AddWithValue("@Answer3", tbAnswerSign3.Text);
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            else if (cbAnswerSign2.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Update TRAFFICSIGN Set ID_SIGN = @ID, QUESTIONSIGN = @Question, SIGN = @Sign, ANSWER1 = @Answer1, ANSWER2 = @Answer2, ANSWER3 = @Answer3, FLAG = @Flag Where QUESTIONSIGN = '" + tbQuestionSign.Text + "'", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", idSign);
                cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Question", tbQuestionSign.Text);
                cmd.Parameters["@Question"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@Sign", SqlDbType.Image);
                cmd.Parameters["@Sign"].Direction = ParameterDirection.Input;                
                cmd.Parameters["@Sign"].Value = imageData;
                cmd.Parameters.AddWithValue("@Answer1", tbAnswerSign1.Text);
                cmd.Parameters.AddWithValue("@Answer2", tbAnswerSign2.Text);
                cmd.Parameters.AddWithValue("@Answer3", tbAnswerSign3.Text);
                cmd.Parameters.AddWithValue("@Flag", 2);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            else if(cbAnswerSign3.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Update TRAFFICSIGN Set ID_SIGN = '@ID', QUESTIONSIGN = '@Question', SIGN = '@Sign', ANSWER1 ='@Answer1', ANSWER2 = '@Answer2', ANSWER3 = '@Answer3', FLAG = '@Flag'" + "Where QUESTIONSIGN = '" + tbQuestionSign.Text + "'", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", idSign);
                cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Question", tbQuestionSign.Text);
                cmd.Parameters["@Question"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@Sign", SqlDbType.Image);
                cmd.Parameters["@Sign"].Direction = ParameterDirection.Input;                
                cmd.Parameters["@Sign"].Value = imageData;
                cmd.Parameters.AddWithValue("@Answer1", tbAnswerSign1.Text);
                cmd.Parameters.AddWithValue("@Answer2", tbAnswerSign2.Text);
                cmd.Parameters.AddWithValue("@Answer3", tbAnswerSign3.Text);
                cmd.Parameters.AddWithValue("@Flag", 3);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }                       
            LoadSign();
            resetSign();
        }

        private void btDeleteSign_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=FAMILY-PC; database=DriverLicenseTest; integrated security= true");
            conn.Open();
            myCommand = new SqlCommand("delete from TRAFFICSIGN where ID_SIGN = '" + idSign + "'", conn);
            myCommand.ExecuteNonQuery();
            conn.Close();
            LoadSign();
            resetSign();
        }

        private void resetSign()
        {
            tbQuestionSign.Text = "";
            tbAnswerSign1.Text = "";
            tbAnswerSign2.Text = "";
            tbAnswerSign3.Text = "";
            pbSign.Image = null;
            cbAnswerSign1.Checked = false;
            cbAnswerSign2.Checked = false;
            cbAnswerSign3.Checked = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetSign();
            reset();
            resetUser();
        }

        private void gridViewSign_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string flag = gridViewSign.CurrentRow.Cells[6].Value.ToString();
            if (flag == "1")
            {
                cbAnswerSign1.Checked = true;
            }
            else if (flag == "2")
            {
                cbAnswerSign2.Checked = true;
            }
            else if (flag == "3")
            {
                cbAnswerSign3.Checked = true;
            }
            tbQuestionSign.Text = gridViewSign.CurrentRow.Cells[1].Value.ToString();
            tbAnswerSign1.Text = gridViewSign.CurrentRow.Cells[3].Value.ToString();
            tbAnswerSign2.Text = gridViewSign.CurrentRow.Cells[4].Value.ToString();
            tbAnswerSign3.Text = gridViewSign.CurrentRow.Cells[5].Value.ToString();
            Image myImage = ByteArrayToImage((byte[])gridViewSign.CurrentRow.Cells[2].Value);
            pbSign.Image = myImage;
            imageData = (byte[])gridViewSign.CurrentRow.Cells[2].Value;
            idSign = (int)gridViewSign.CurrentRow.Cells[0].Value;
        }

        private void cbAnswerSign1_Click(object sender, EventArgs e)
        {
            cbAnswerSign2.Checked = false;
            cbAnswerSign3.Checked = false;
        }

        private void cbAnswerSign2_Click(object sender, EventArgs e)
        {
            cbAnswerSign1.Checked = false;
            cbAnswerSign3.Checked = false;
        }

        private void cbAnswerSign3_Click(object sender, EventArgs e)
        {
            cbAnswerSign2.Checked = false;
            cbAnswerSign1.Checked = false;
        }

        private void cbAnwser1_Click(object sender, EventArgs e)
        {
            cbAnswer2.Checked = false;
            cbAnswer3.Checked = false;
        }

        private void cbAnswer2_Click(object sender, EventArgs e)
        {
            cbAnswer1.Checked = false;
            cbAnswer3.Checked = false;
        }

        private void cbAnswer3_Click(object sender, EventArgs e)
        {
            cbAnswer1.Checked = false;
            cbAnswer2.Checked = false;
        }
    }
}
