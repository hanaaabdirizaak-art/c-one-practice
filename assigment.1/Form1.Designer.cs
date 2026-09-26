namespace assigment._1
{
    partial class Ibloutput
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
            this.txtname = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.Label();
            this.txtsemester = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.MaskedTextBox();
            this.txtStudenid = new System.Windows.Forms.MaskedTextBox();
            this.textdepartment = new System.Windows.Forms.MaskedTextBox();
            this.textsemester = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(215, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(177, 20);
            this.txtname.TabIndex = 4;
            this.txtname.Text = "Enter the student name";
            // 
            // txtstudentid
            // 
            this.txtstudentid.AutoSize = true;
            this.txtstudentid.Location = new System.Drawing.Point(215, 87);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(154, 20);
            this.txtstudentid.TabIndex = 5;
            this.txtstudentid.Text = "Enter the student ID";
            this.txtstudentid.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdepartment
            // 
            this.txtdepartment.AutoSize = true;
            this.txtdepartment.Location = new System.Drawing.Point(215, 132);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(165, 20);
            this.txtdepartment.TabIndex = 6;
            this.txtdepartment.Text = "Enter  the department";
            // 
            // txtsemester
            // 
            this.txtsemester.AutoSize = true;
            this.txtsemester.Location = new System.Drawing.Point(215, 173);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(145, 20);
            this.txtsemester.TabIndex = 7;
            this.txtsemester.Text = "Enter the semester";
            this.txtsemester.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbloutput.Location = new System.Drawing.Point(271, 243);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(325, 20);
            this.lbloutput.TabIndex = 8;
            this.lbloutput.Text = "                                                                               \r\n" +
    "";
            this.lbloutput.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(256, 306);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(72, 26);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(396, 306);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 26);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(596, 306);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(72, 26);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(507, 46);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(217, 26);
            this.textname.TabIndex = 12;
            // 
            // txtStudenid
            // 
            this.txtStudenid.Location = new System.Drawing.Point(500, 78);
            this.txtStudenid.Name = "txtStudenid";
            this.txtStudenid.Size = new System.Drawing.Size(224, 26);
            this.txtStudenid.TabIndex = 13;
            this.txtStudenid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textdepartment
            // 
            this.textdepartment.Location = new System.Drawing.Point(500, 124);
            this.textdepartment.Name = "textdepartment";
            this.textdepartment.Size = new System.Drawing.Size(234, 26);
            this.textdepartment.TabIndex = 14;
            // 
            // textsemester
            // 
            this.textsemester.Location = new System.Drawing.Point(500, 167);
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(224, 26);
            this.textsemester.TabIndex = 15;
            this.textsemester.Text = "                       ";
            // 
            // Ibloutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textdepartment);
            this.Controls.Add(this.txtStudenid);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Name = "Ibloutput";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtstudentid;
        private System.Windows.Forms.Label txtdepartment;
        private System.Windows.Forms.Label txtsemester;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.MaskedTextBox txtStudenid;
        private System.Windows.Forms.MaskedTextBox textdepartment;
        private System.Windows.Forms.MaskedTextBox textsemester;
        private System.Windows.Forms.MaskedTextBox textname;
    }
}

