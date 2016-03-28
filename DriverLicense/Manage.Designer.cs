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
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAnswer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnswer3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabQuestion.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(653, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(717, 7);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(35, 13);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "label2";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(805, 285);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 3;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(805, 328);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(805, 371);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuestion);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 444);
            this.tabControl1.TabIndex = 6;
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.tbAnswer3);
            this.tabQuestion.Controls.Add(this.label5);
            this.tabQuestion.Controls.Add(this.tbAnswer2);
            this.tabQuestion.Controls.Add(this.label4);
            this.tabQuestion.Controls.Add(this.tbAnswer1);
            this.tabQuestion.Controls.Add(this.label3);
            this.tabQuestion.Controls.Add(this.tbQuestion);
            this.tabQuestion.Controls.Add(this.label2);
            this.tabQuestion.Controls.Add(this.btUpdate);
            this.tabQuestion.Controls.Add(this.btDelete);
            this.tabQuestion.Controls.Add(this.lbListQuestion);
            this.tabQuestion.Controls.Add(this.btNew);
            this.tabQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(886, 418);
            this.tabQuestion.TabIndex = 0;
            this.tabQuestion.Text = "Question";
            this.tabQuestion.UseVisualStyleBackColor = true;
            // 
            // tabUser
            // 
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(886, 418);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question: ";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(62, 277);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(363, 74);
            this.tbQuestion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer 1:";
            // 
            // tbAnswer1
            // 
            this.tbAnswer1.Location = new System.Drawing.Point(62, 357);
            this.tbAnswer1.Multiline = true;
            this.tbAnswer1.Name = "tbAnswer1";
            this.tbAnswer1.Size = new System.Drawing.Size(363, 51);
            this.tbAnswer1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Answer 2:";
            // 
            // tbAnswer2
            // 
            this.tbAnswer2.Location = new System.Drawing.Point(503, 280);
            this.tbAnswer2.Multiline = true;
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.Size = new System.Drawing.Size(296, 45);
            this.tbAnswer2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer 3:";
            // 
            // tbAnswer3
            // 
            this.tbAnswer3.Location = new System.Drawing.Point(503, 357);
            this.tbAnswer3.Multiline = true;
            this.tbAnswer3.Name = "tbAnswer3";
            this.tbAnswer3.Size = new System.Drawing.Size(296, 51);
            this.tbAnswer3.TabIndex = 9;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.tabControl1.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnswer3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAnswer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnswer1;
    }
}