namespace Activity_14_attempt
{
    partial class Form1
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
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.checkbx1 = new System.Windows.Forms.CheckBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.genderLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.checkbx2 = new System.Windows.Forms.CheckBox();
            this.textBoxFriends = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMyFriends = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbx3 = new System.Windows.Forms.CheckBox();
            this.checkbx4 = new System.Windows.Forms.CheckBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioBtn.Location = new System.Drawing.Point(17, 143);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(80, 25);
            this.maleRadioBtn.TabIndex = 0;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            this.maleRadioBtn.CheckedChanged += new System.EventHandler(this.maleRadioBtn_CheckedChanged);
            // 
            // checkbx1
            // 
            this.checkbx1.AutoSize = true;
            this.checkbx1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx1.Location = new System.Drawing.Point(17, 273);
            this.checkbx1.Name = "checkbx1";
            this.checkbx1.Size = new System.Drawing.Size(81, 25);
            this.checkbx1.TabIndex = 1;
            this.checkbx1.Text = "1-20";
            this.checkbx1.UseVisualStyleBackColor = true;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(249, 197);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(198, 221);
            this.listBoxFriends.TabIndex = 2;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioBtn.Location = new System.Drawing.Point(17, 185);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(106, 25);
            this.femaleRadioBtn.TabIndex = 3;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            this.femaleRadioBtn.CheckedChanged += new System.EventHandler(this.femaleRadioBtn_CheckedChanged);
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(12, 100);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(136, 21);
            this.genderLbl.TabIndex = 4;
            this.genderLbl.Text = "My Gender";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(12, 230);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(94, 21);
            this.ageLbl.TabIndex = 5;
            this.ageLbl.Text = "My Age";
            // 
            // checkbx2
            // 
            this.checkbx2.AutoSize = true;
            this.checkbx2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx2.Location = new System.Drawing.Point(17, 312);
            this.checkbx2.Name = "checkbx2";
            this.checkbx2.Size = new System.Drawing.Size(94, 25);
            this.checkbx2.TabIndex = 6;
            this.checkbx2.Text = "21-40";
            this.checkbx2.UseVisualStyleBackColor = true;
            this.checkbx2.CheckedChanged += new System.EventHandler(this.checkbx2_CheckedChanged);
            // 
            // textBoxFriends
            // 
            this.textBoxFriends.Location = new System.Drawing.Point(249, 141);
            this.textBoxFriends.Name = "textBoxFriends";
            this.textBoxFriends.Size = new System.Drawing.Size(198, 20);
            this.textBoxFriends.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(376, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMyFriends
            // 
            this.lblMyFriends.AutoSize = true;
            this.lblMyFriends.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyFriends.Location = new System.Drawing.Point(245, 101);
            this.lblMyFriends.Name = "lblMyFriends";
            this.lblMyFriends.Size = new System.Drawing.Size(150, 21);
            this.lblMyFriends.TabIndex = 9;
            this.lblMyFriends.Text = "My Friends";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(8, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hello World!!!!";
            // 
            // checkbx3
            // 
            this.checkbx3.AutoSize = true;
            this.checkbx3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx3.Location = new System.Drawing.Point(17, 352);
            this.checkbx3.Name = "checkbx3";
            this.checkbx3.Size = new System.Drawing.Size(94, 25);
            this.checkbx3.TabIndex = 12;
            this.checkbx3.Text = "41-60";
            this.checkbx3.UseVisualStyleBackColor = true;
            // 
            // checkbx4
            // 
            this.checkbx4.AutoSize = true;
            this.checkbx4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx4.Location = new System.Drawing.Point(17, 393);
            this.checkbx4.Name = "checkbx4";
            this.checkbx4.Size = new System.Drawing.Size(68, 25);
            this.checkbx4.TabIndex = 13;
            this.checkbx4.Text = "60+";
            this.checkbx4.UseVisualStyleBackColor = true;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(148, 145);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(95, 13);
            this.lblEnterName.TabIndex = 14;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(476, 539);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.checkbx4);
            this.Controls.Add(this.checkbx3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMyFriends);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxFriends);
            this.Controls.Add(this.checkbx2);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.checkbx1);
            this.Controls.Add(this.maleRadioBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Info About Yourself";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.CheckBox checkbx1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.CheckBox checkbx2;
        private System.Windows.Forms.TextBox textBoxFriends;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMyFriends;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbx3;
        private System.Windows.Forms.CheckBox checkbx4;
        private System.Windows.Forms.Label lblEnterName;
    }
}

