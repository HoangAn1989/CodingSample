namespace DriverLicense
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbListQuestion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.cbAnswer3 = new System.Windows.Forms.CheckBox();
            this.cbAnswer2 = new System.Windows.Forms.CheckBox();
            this.cbAnswer1 = new System.Windows.Forms.CheckBox();
            this.btUnSelectQuestion = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.tbAnswer3 = new System.Windows.Forms.TextBox();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.tbAnswer1 = new System.Windows.Forms.TextBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btUnSelect = new System.Windows.Forms.Button();
            this.btNewUser = new System.Windows.Forms.Button();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.btUpdateUser = new System.Windows.Forms.Button();
            this.btSelectUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lboxUser = new System.Windows.Forms.ListBox();
            this.Signs = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridViewSign = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDeleteSign = new System.Windows.Forms.Button();
            this.btUpdateSign = new System.Windows.Forms.Button();
            this.cbAnswerSign3 = new System.Windows.Forms.CheckBox();
            this.cbAnswerSign2 = new System.Windows.Forms.CheckBox();
            this.tbAnswerSign3 = new System.Windows.Forms.TextBox();
            this.tbAnswerSign2 = new System.Windows.Forms.TextBox();
            this.cbAnswerSign1 = new System.Windows.Forms.CheckBox();
            this.tbAnswerSign1 = new System.Windows.Forms.TextBox();
            this.btNewSign = new System.Windows.Forms.Button();
            this.btChooseSign2 = new System.Windows.Forms.Button();
            this.pbSign = new System.Windows.Forms.PictureBox();
            this.tbQuestionSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogSign2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.Signs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSign)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListQuestion
            // 
            this.lbListQuestion.FormattingEnabled = true;
            this.lbListQuestion.Location = new System.Drawing.Point(6, 6);
            this.lbListQuestion.Name = "lbListQuestion";
            this.lbListQuestion.Size = new System.Drawing.Size(874, 251);
            this.lbListQuestion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(717, 3);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(35, 13);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "label2";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(790, 264);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 3;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(473, 263);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(637, 263);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuestion);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.Signs);
            this.tabControl1.Location = new System.Drawing.Point(0, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 461);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.cbAnswer3);
            this.tabQuestion.Controls.Add(this.cbAnswer2);
            this.tabQuestion.Controls.Add(this.cbAnswer1);
            this.tabQuestion.Controls.Add(this.btUnSelectQuestion);
            this.tabQuestion.Controls.Add(this.btSelect);
            this.tabQuestion.Controls.Add(this.tbAnswer3);
            this.tabQuestion.Controls.Add(this.tbAnswer2);
            this.tabQuestion.Controls.Add(this.tbAnswer1);
            this.tabQuestion.Controls.Add(this.tbQuestion);
            this.tabQuestion.Controls.Add(this.label2);
            this.tabQuestion.Controls.Add(this.btUpdate);
            this.tabQuestion.Controls.Add(this.btDelete);
            this.tabQuestion.Controls.Add(this.lbListQuestion);
            this.tabQuestion.Controls.Add(this.btNew);
            this.tabQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(886, 435);
            this.tabQuestion.TabIndex = 0;
            this.tabQuestion.Text = "Question";
            this.tabQuestion.UseVisualStyleBackColor = true;
            // 
            // cbAnswer3
            // 
            this.cbAnswer3.AutoSize = true;
            this.cbAnswer3.Location = new System.Drawing.Point(490, 387);
            this.cbAnswer3.Name = "cbAnswer3";
            this.cbAnswer3.Size = new System.Drawing.Size(73, 17);
            this.cbAnswer3.TabIndex = 14;
            this.cbAnswer3.Text = "Answer 3:";
            this.cbAnswer3.UseVisualStyleBackColor = true;
            this.cbAnswer3.Click += new System.EventHandler(this.cbAnswer3_Click);
            // 
            // cbAnswer2
            // 
            this.cbAnswer2.AutoSize = true;
            this.cbAnswer2.Location = new System.Drawing.Point(490, 309);
            this.cbAnswer2.Name = "cbAnswer2";
            this.cbAnswer2.Size = new System.Drawing.Size(73, 17);
            this.cbAnswer2.TabIndex = 13;
            this.cbAnswer2.Text = "Answer 2:";
            this.cbAnswer2.UseVisualStyleBackColor = true;
            this.cbAnswer2.Click += new System.EventHandler(this.cbAnswer2_Click);
            // 
            // cbAnswer1
            // 
            this.cbAnswer1.AutoSize = true;
            this.cbAnswer1.Location = new System.Drawing.Point(23, 387);
            this.cbAnswer1.Name = "cbAnswer1";
            this.cbAnswer1.Size = new System.Drawing.Size(73, 17);
            this.cbAnswer1.TabIndex = 12;
            this.cbAnswer1.Text = "Answer 1:";
            this.cbAnswer1.UseVisualStyleBackColor = true;
            this.cbAnswer1.Click += new System.EventHandler(this.cbAnwser1_Click);
            // 
            // btUnSelectQuestion
            // 
            this.btUnSelectQuestion.Location = new System.Drawing.Point(208, 264);
            this.btUnSelectQuestion.Name = "btUnSelectQuestion";
            this.btUnSelectQuestion.Size = new System.Drawing.Size(75, 23);
            this.btUnSelectQuestion.TabIndex = 11;
            this.btUnSelectQuestion.Text = "UnSelect";
            this.btUnSelectQuestion.UseVisualStyleBackColor = true;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(62, 264);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 10;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbAnswer3
            // 
            this.tbAnswer3.Location = new System.Drawing.Point(566, 373);
            this.tbAnswer3.Multiline = true;
            this.tbAnswer3.Name = "tbAnswer3";
            this.tbAnswer3.Size = new System.Drawing.Size(296, 51);
            this.tbAnswer3.TabIndex = 9;
            // 
            // tbAnswer2
            // 
            this.tbAnswer2.Location = new System.Drawing.Point(566, 296);
            this.tbAnswer2.Multiline = true;
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.Size = new System.Drawing.Size(296, 45);
            this.tbAnswer2.TabIndex = 9;
            // 
            // tbAnswer1
            // 
            this.tbAnswer1.Location = new System.Drawing.Point(99, 373);
            this.tbAnswer1.Multiline = true;
            this.tbAnswer1.Name = "tbAnswer1";
            this.tbAnswer1.Size = new System.Drawing.Size(363, 51);
            this.tbAnswer1.TabIndex = 9;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(99, 293);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(363, 74);
            this.tbQuestion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question: ";
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btUnSelect);
            this.tabUser.Controls.Add(this.btNewUser);
            this.tabUser.Controls.Add(this.btDeleteUser);
            this.tabUser.Controls.Add(this.btUpdateUser);
            this.tabUser.Controls.Add(this.btSelectUser);
            this.tabUser.Controls.Add(this.label7);
            this.tabUser.Controls.Add(this.label6);
            this.tabUser.Controls.Add(this.tbPass);
            this.tabUser.Controls.Add(this.tbUser);
            this.tabUser.Controls.Add(this.lboxUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(886, 435);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btUnSelect
            // 
            this.btUnSelect.Location = new System.Drawing.Point(579, 117);
            this.btUnSelect.Name = "btUnSelect";
            this.btUnSelect.Size = new System.Drawing.Size(75, 23);
            this.btUnSelect.TabIndex = 4;
            this.btUnSelect.Text = "UnSelect";
            this.btUnSelect.UseVisualStyleBackColor = true;
            this.btUnSelect.Click += new System.EventHandler(this.btUnSelect_Click);
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(741, 252);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(75, 23);
            this.btNewUser.TabIndex = 3;
            this.btNewUser.Text = "New";
            this.btNewUser.UseVisualStyleBackColor = true;
            this.btNewUser.Click += new System.EventHandler(this.btNewUser_Click);
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Location = new System.Drawing.Point(741, 179);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btDeleteUser.TabIndex = 3;
            this.btDeleteUser.Text = "Delete";
            this.btDeleteUser.UseVisualStyleBackColor = true;
            this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.Location = new System.Drawing.Point(741, 118);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btUpdateUser.TabIndex = 3;
            this.btUpdateUser.Text = "Update";
            this.btUpdateUser.UseVisualStyleBackColor = true;
            this.btUpdateUser.Click += new System.EventHandler(this.btUpdateUser_Click);
            // 
            // btSelectUser
            // 
            this.btSelectUser.Location = new System.Drawing.Point(426, 118);
            this.btSelectUser.Name = "btSelectUser";
            this.btSelectUser.Size = new System.Drawing.Size(75, 23);
            this.btSelectUser.TabIndex = 3;
            this.btSelectUser.Text = "Select";
            this.btSelectUser.UseVisualStyleBackColor = true;
            this.btSelectUser.Click += new System.EventHandler(this.btSelectUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pass Word:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "User Name: ";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(485, 57);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(187, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(485, 11);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(187, 20);
            this.tbUser.TabIndex = 1;
            // 
            // lboxUser
            // 
            this.lboxUser.FormattingEnabled = true;
            this.lboxUser.Location = new System.Drawing.Point(6, 6);
            this.lboxUser.Name = "lboxUser";
            this.lboxUser.Size = new System.Drawing.Size(369, 420);
            this.lboxUser.TabIndex = 0;
            // 
            // Signs
            // 
            this.Signs.Controls.Add(this.groupBox3);
            this.Signs.Controls.Add(this.groupBox1);
            this.Signs.Location = new System.Drawing.Point(4, 22);
            this.Signs.Name = "Signs";
            this.Signs.Size = new System.Drawing.Size(886, 435);
            this.Signs.TabIndex = 2;
            this.Signs.Text = "Signs";
            this.Signs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridViewSign);
            this.groupBox3.Location = new System.Drawing.Point(434, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 429);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gridViewSign
            // 
            this.gridViewSign.ColumnHeadersHeight = 50;
            this.gridViewSign.Location = new System.Drawing.Point(6, 19);
            this.gridViewSign.Name = "gridViewSign";
            this.gridViewSign.Size = new System.Drawing.Size(439, 408);
            this.gridViewSign.TabIndex = 0;
            this.gridViewSign.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSign_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeleteSign);
            this.groupBox1.Controls.Add(this.btUpdateSign);
            this.groupBox1.Controls.Add(this.cbAnswerSign3);
            this.groupBox1.Controls.Add(this.cbAnswerSign2);
            this.groupBox1.Controls.Add(this.tbAnswerSign3);
            this.groupBox1.Controls.Add(this.tbAnswerSign2);
            this.groupBox1.Controls.Add(this.cbAnswerSign1);
            this.groupBox1.Controls.Add(this.tbAnswerSign1);
            this.groupBox1.Controls.Add(this.btNewSign);
            this.groupBox1.Controls.Add(this.btChooseSign2);
            this.groupBox1.Controls.Add(this.pbSign);
            this.groupBox1.Controls.Add(this.tbQuestionSign);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btDeleteSign
            // 
            this.btDeleteSign.Location = new System.Drawing.Point(36, 397);
            this.btDeleteSign.Name = "btDeleteSign";
            this.btDeleteSign.Size = new System.Drawing.Size(83, 26);
            this.btDeleteSign.TabIndex = 19;
            this.btDeleteSign.Text = "Delete";
            this.btDeleteSign.UseVisualStyleBackColor = true;
            this.btDeleteSign.Click += new System.EventHandler(this.btDeleteSign_Click);
            // 
            // btUpdateSign
            // 
            this.btUpdateSign.Location = new System.Drawing.Point(36, 345);
            this.btUpdateSign.Name = "btUpdateSign";
            this.btUpdateSign.Size = new System.Drawing.Size(83, 26);
            this.btUpdateSign.TabIndex = 19;
            this.btUpdateSign.Text = "Update";
            this.btUpdateSign.UseVisualStyleBackColor = true;
            this.btUpdateSign.Click += new System.EventHandler(this.btUpdateSign_Click);
            // 
            // cbAnswerSign3
            // 
            this.cbAnswerSign3.AutoSize = true;
            this.cbAnswerSign3.Location = new System.Drawing.Point(8, 236);
            this.cbAnswerSign3.Name = "cbAnswerSign3";
            this.cbAnswerSign3.Size = new System.Drawing.Size(73, 17);
            this.cbAnswerSign3.TabIndex = 18;
            this.cbAnswerSign3.Text = "Answer 3:";
            this.cbAnswerSign3.UseVisualStyleBackColor = true;
            this.cbAnswerSign3.Click += new System.EventHandler(this.cbAnswerSign3_Click);
            // 
            // cbAnswerSign2
            // 
            this.cbAnswerSign2.AutoSize = true;
            this.cbAnswerSign2.Location = new System.Drawing.Point(8, 184);
            this.cbAnswerSign2.Name = "cbAnswerSign2";
            this.cbAnswerSign2.Size = new System.Drawing.Size(73, 17);
            this.cbAnswerSign2.TabIndex = 17;
            this.cbAnswerSign2.Text = "Answer 2:";
            this.cbAnswerSign2.UseVisualStyleBackColor = true;
            this.cbAnswerSign2.Click += new System.EventHandler(this.cbAnswerSign2_Click);
            // 
            // tbAnswerSign3
            // 
            this.tbAnswerSign3.Location = new System.Drawing.Point(84, 222);
            this.tbAnswerSign3.Multiline = true;
            this.tbAnswerSign3.Name = "tbAnswerSign3";
            this.tbAnswerSign3.Size = new System.Drawing.Size(335, 51);
            this.tbAnswerSign3.TabIndex = 15;
            // 
            // tbAnswerSign2
            // 
            this.tbAnswerSign2.Location = new System.Drawing.Point(84, 171);
            this.tbAnswerSign2.Multiline = true;
            this.tbAnswerSign2.Name = "tbAnswerSign2";
            this.tbAnswerSign2.Size = new System.Drawing.Size(335, 45);
            this.tbAnswerSign2.TabIndex = 16;
            // 
            // cbAnswerSign1
            // 
            this.cbAnswerSign1.AutoSize = true;
            this.cbAnswerSign1.Location = new System.Drawing.Point(8, 128);
            this.cbAnswerSign1.Name = "cbAnswerSign1";
            this.cbAnswerSign1.Size = new System.Drawing.Size(73, 17);
            this.cbAnswerSign1.TabIndex = 14;
            this.cbAnswerSign1.Text = "Answer 1:";
            this.cbAnswerSign1.UseVisualStyleBackColor = true;
            this.cbAnswerSign1.Click += new System.EventHandler(this.cbAnswerSign1_Click);
            // 
            // tbAnswerSign1
            // 
            this.tbAnswerSign1.Location = new System.Drawing.Point(84, 114);
            this.tbAnswerSign1.Multiline = true;
            this.tbAnswerSign1.Name = "tbAnswerSign1";
            this.tbAnswerSign1.Size = new System.Drawing.Size(335, 51);
            this.tbAnswerSign1.TabIndex = 13;
            // 
            // btNewSign
            // 
            this.btNewSign.Location = new System.Drawing.Point(36, 295);
            this.btNewSign.Name = "btNewSign";
            this.btNewSign.Size = new System.Drawing.Size(83, 26);
            this.btNewSign.TabIndex = 4;
            this.btNewSign.Text = "New";
            this.btNewSign.UseVisualStyleBackColor = true;
            this.btNewSign.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btChooseSign2
            // 
            this.btChooseSign2.Location = new System.Drawing.Point(179, 345);
            this.btChooseSign2.Name = "btChooseSign2";
            this.btChooseSign2.Size = new System.Drawing.Size(90, 29);
            this.btChooseSign2.TabIndex = 3;
            this.btChooseSign2.Text = "Choose Image";
            this.btChooseSign2.UseVisualStyleBackColor = true;
            this.btChooseSign2.Click += new System.EventHandler(this.btChooseSign2_Click);
            // 
            // pbSign
            // 
            this.pbSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSign.Location = new System.Drawing.Point(284, 279);
            this.pbSign.Name = "pbSign";
            this.pbSign.Size = new System.Drawing.Size(135, 144);
            this.pbSign.TabIndex = 2;
            this.pbSign.TabStop = false;
            // 
            // tbQuestionSign
            // 
            this.tbQuestionSign.Location = new System.Drawing.Point(5, 36);
            this.tbQuestionSign.Multiline = true;
            this.tbQuestionSign.Name = "tbQuestionSign";
            this.tbQuestionSign.Size = new System.Drawing.Size(414, 72);
            this.tbQuestionSign.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Question:";
            // 
            // openFileDialogSign2
            // 
            this.openFileDialogSign2.FileName = "openFileDialog1";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manage_FormClosed);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.Signs.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSign)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnswer3;
        private System.Windows.Forms.TextBox tbAnswer2;
        private System.Windows.Forms.TextBox tbAnswer1;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Button btDeleteUser;
        private System.Windows.Forms.Button btUpdateUser;
        private System.Windows.Forms.Button btSelectUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.ListBox lboxUser;
        private System.Windows.Forms.Button btUnSelect;
        private System.Windows.Forms.Button btUnSelectQuestion;
        private System.Windows.Forms.CheckBox cbAnswer3;
        private System.Windows.Forms.CheckBox cbAnswer2;
        private System.Windows.Forms.CheckBox cbAnswer1;
        private System.Windows.Forms.TabPage Signs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewSign;
        private System.Windows.Forms.Button btNewSign;
        private System.Windows.Forms.Button btChooseSign2;
        private System.Windows.Forms.PictureBox pbSign;
        private System.Windows.Forms.TextBox tbQuestionSign;
        private System.Windows.Forms.OpenFileDialog openFileDialogSign2;
        private System.Windows.Forms.CheckBox cbAnswerSign3;
        private System.Windows.Forms.CheckBox cbAnswerSign2;
        private System.Windows.Forms.TextBox tbAnswerSign3;
        private System.Windows.Forms.TextBox tbAnswerSign2;
        private System.Windows.Forms.CheckBox cbAnswerSign1;
        private System.Windows.Forms.TextBox tbAnswerSign1;
        private System.Windows.Forms.Button btDeleteSign;
        private System.Windows.Forms.Button btUpdateSign;
    }
}