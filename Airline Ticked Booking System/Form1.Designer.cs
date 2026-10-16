namespace Airline_Ticked_Booking_System
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
            this.lblairline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpassgen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbladitional = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.MaskedTextBox();
            this.txtPassengerAge = new System.Windows.Forms.MaskedTextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.MaskedTextBox();
            this.txtBaggageWeight = new System.Windows.Forms.MaskedTextBox();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.txtBookingDetails = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblairline
            // 
            this.lblairline.AutoSize = true;
            this.lblairline.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblairline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblairline.Location = new System.Drawing.Point(8, 9);
            this.lblairline.Name = "lblairline";
            this.lblairline.Size = new System.Drawing.Size(782, 29);
            this.lblairline.TabIndex = 0;
            this.lblairline.Text = " Airline Ticket Booking System                                                   " +
    "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panssenger Name:";
            // 
            // lblpassgen
            // 
            this.lblpassgen.AutoSize = true;
            this.lblpassgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassgen.Location = new System.Drawing.Point(61, 131);
            this.lblpassgen.Name = "lblpassgen";
            this.lblpassgen.Size = new System.Drawing.Size(156, 25);
            this.lblpassgen.TabIndex = 3;
            this.lblpassgen.Text = "Pasenger Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number O f Ticket:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baggage weight(Kg):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Travel Class";
            // 
            // lbladitional
            // 
            this.lbladitional.AutoSize = true;
            this.lbladitional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladitional.Location = new System.Drawing.Point(12, 418);
            this.lbladitional.Name = "lbladitional";
            this.lbladitional.Size = new System.Drawing.Size(178, 25);
            this.lbladitional.TabIndex = 7;
            this.lbladitional.Text = "AdditionOptional ";
            this.lbladitional.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(262, 81);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(169, 26);
            this.txtPassengerName.TabIndex = 8;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(263, 125);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(170, 26);
            this.txtPassengerAge.TabIndex = 9;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(252, 176);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.ReadOnly = true;
            this.txtNumberOfTickets.Size = new System.Drawing.Size(181, 26);
            this.txtNumberOfTickets.TabIndex = 10;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(250, 214);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(183, 26);
            this.txtBaggageWeight.TabIndex = 11;
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstClass.Location = new System.Drawing.Point(64, 351);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(139, 29);
            this.rdoFirstClass.TabIndex = 12;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "first classs";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(287, 360);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(166, 29);
            this.rdoNormalClass.TabIndex = 13;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(519, 364);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(197, 29);
            this.rdoBusinessClass.TabIndex = 14;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Bussiness Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsurance.Location = new System.Drawing.Point(29, 452);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(401, 29);
            this.chkInsurance.TabIndex = 15;
            this.chkInsurance.Text = "Add Travel Insurance($25 Per Ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.FormattingEnabled = true;
            this.txtBookingDetails.ItemHeight = 20;
            this.txtBookingDetails.Location = new System.Drawing.Point(537, 54);
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.Size = new System.Drawing.Size(211, 304);
            this.txtBookingDetails.TabIndex = 19;
            this.txtBookingDetails.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(36, 510);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(133, 61);
            this.btncalculate.TabIndex = 20;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(230, 510);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 61);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(451, 502);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 61);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.chkInsurance);
            this.Controls.Add(this.rdoBusinessClass);
            this.Controls.Add(this.rdoNormalClass);
            this.Controls.Add(this.rdoFirstClass);
            this.Controls.Add(this.txtBaggageWeight);
            this.Controls.Add(this.txtNumberOfTickets);
            this.Controls.Add(this.txtPassengerAge);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lbladitional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpassgen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblairline);
            this.Name = "Form1";
            this.Text = " txtBookingDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblairline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpassgen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbladitional;
        private System.Windows.Forms.MaskedTextBox txtPassengerName;
        private System.Windows.Forms.MaskedTextBox txtPassengerAge;
        private System.Windows.Forms.MaskedTextBox txtNumberOfTickets;
        private System.Windows.Forms.MaskedTextBox txtBaggageWeight;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.ListBox txtBookingDetails;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

