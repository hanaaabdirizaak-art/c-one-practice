namespace assignment.home
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(35, 62);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(151, 56);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(35, 145);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(151, 56);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(35, 207);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(151, 56);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(45, 282);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(151, 48);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(457, 71);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileName.Size = new System.Drawing.Size(100, 26);
            this.txtFileName.TabIndex = 4;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(457, 145);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(100, 26);
            this.txtContent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form1";
            this.Text = "txtFileName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtContent;
    }
}

