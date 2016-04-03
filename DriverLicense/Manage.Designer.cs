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
            this.cbAnwser1 = new System.Windows.Forms.CheckBox();
            this.cbAnswer2 = new System.Windows.Forms.CheckBox();
            this.cbAnswer3 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.tabUser.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 461);
            this.tabControl1.TabIndex = 6;
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.cbAnswer3);
            this.tabQuestion.Controls.Add(this.cbAnswer2);
            this.tabQuestion.Controls.Add(this.cbAnwser1);
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
            // cbAnwser1
            // 
            this.cbAnwser1.AutoSize = true;
            this.cbAnwser1.Location = new System.Drawing.Point(23, 387);
            this.cbAnwser1.Name = "cbAnwser1";
            this.cbAnwser1.Size = new System.Drawing.Size(73, 17);
            this.cbAnwser1.TabIndex = 12;
            this.cbAnwser1.Text = "Answer 1:";
            this.cbAnwser1.UseVisualStyleBackColor = true;
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
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbAnwser1;
    }
}