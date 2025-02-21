namespace StudentRegistration1
{
    partial class StudentFrame
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassward = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassward = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.rdBtnM = new System.Windows.Forms.RadioButton();
            this.rdBtnW = new System.Windows.Forms.RadioButton();
            this.rdBtnO = new System.Windows.Forms.RadioButton();
            this.cmboBoxBirthPlace = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(279, 20);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(87, 53);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(285, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 46);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = " Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPassward
            // 
            this.lblPassward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassward.Location = new System.Drawing.Point(279, 130);
            this.lblPassward.Name = "lblPassward";
            this.lblPassward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassward.Size = new System.Drawing.Size(87, 46);
            this.lblPassward.TabIndex = 2;
            this.lblPassward.Text = "Passward :";
            this.lblPassward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassward.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGender
            // 
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(279, 188);
            this.lblGender.Name = "lblGender";
            this.lblGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGender.Size = new System.Drawing.Size(87, 46);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGender.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBirthPlace.Location = new System.Drawing.Point(273, 241);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBirthPlace.Size = new System.Drawing.Size(99, 46);
            this.lblBirthPlace.TabIndex = 5;
            this.lblBirthPlace.Text = "Birth Place :";
            this.lblBirthPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBirthPlace.Click += new System.EventHandler(this.label6_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(382, 34);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 26);
            this.textName.TabIndex = 6;
            // 
            // textPassward
            // 
            this.textPassward.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textPassward.Location = new System.Drawing.Point(382, 150);
            this.textPassward.Name = "textPassward";
            this.textPassward.PasswordChar = '*';
            this.textPassward.Size = new System.Drawing.Size(263, 26);
            this.textPassward.TabIndex = 10;
            this.textPassward.TextChanged += new System.EventHandler(this.textPassward_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(382, 84);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(263, 26);
            this.textEmail.TabIndex = 11;
            // 
            // rdBtnM
            // 
            this.rdBtnM.AutoSize = true;
            this.rdBtnM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnM.Location = new System.Drawing.Point(390, 200);
            this.rdBtnM.Name = "rdBtnM";
            this.rdBtnM.Size = new System.Drawing.Size(59, 22);
            this.rdBtnM.TabIndex = 12;
            this.rdBtnM.TabStop = true;
            this.rdBtnM.Text = "Male";
            this.rdBtnM.UseVisualStyleBackColor = true;
            // 
            // rdBtnW
            // 
            this.rdBtnW.AutoSize = true;
            this.rdBtnW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnW.Location = new System.Drawing.Point(471, 200);
            this.rdBtnW.Name = "rdBtnW";
            this.rdBtnW.Size = new System.Drawing.Size(76, 22);
            this.rdBtnW.TabIndex = 13;
            this.rdBtnW.TabStop = true;
            this.rdBtnW.Text = "Female";
            this.rdBtnW.UseVisualStyleBackColor = true;
            // 
            // rdBtnO
            // 
            this.rdBtnO.AutoSize = true;
            this.rdBtnO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdBtnO.Location = new System.Drawing.Point(579, 200);
            this.rdBtnO.Name = "rdBtnO";
            this.rdBtnO.Size = new System.Drawing.Size(66, 22);
            this.rdBtnO.TabIndex = 14;
            this.rdBtnO.TabStop = true;
            this.rdBtnO.Text = "Other";
            this.rdBtnO.UseVisualStyleBackColor = true;
            // 
            // cmboBoxBirthPlace
            // 
            this.cmboBoxBirthPlace.FormattingEnabled = true;
            this.cmboBoxBirthPlace.Items.AddRange(new object[] {
            "Taiz ",
            "Oden ",
            "Ibb",
            "Sana\'a"});
            this.cmboBoxBirthPlace.Location = new System.Drawing.Point(382, 252);
            this.cmboBoxBirthPlace.Name = "cmboBoxBirthPlace";
            this.cmboBoxBirthPlace.Size = new System.Drawing.Size(249, 26);
            this.cmboBoxBirthPlace.TabIndex = 15;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn.Location = new System.Drawing.Point(399, 340);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(134, 45);
            this.btn.TabIndex = 16;
            this.btn.Text = "Send";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // StudentFrame
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(889, 486);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cmboBoxBirthPlace);
            this.Controls.Add(this.rdBtnO);
            this.Controls.Add(this.rdBtnW);
            this.Controls.Add(this.rdBtnM);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPassward);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassward);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "StudentFrame";
            this.Text = "Student Regestration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassward;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.RadioButton rdBtnM;
        private System.Windows.Forms.RadioButton rdBtnW;
        private System.Windows.Forms.RadioButton rdBtnO;
        private System.Windows.Forms.ComboBox cmboBoxBirthPlace;
        private System.Windows.Forms.Button btn;
    }
  
}

