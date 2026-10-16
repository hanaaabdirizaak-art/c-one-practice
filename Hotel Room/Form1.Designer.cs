namespace Hotel_Room
{
    partial class lstBookingDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lstBookingDetails));
            this.lblhotelroom = new System.Windows.Forms.Label();
            this.lblpersonal = new System.Windows.Forms.Label();
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblguestage = new System.Windows.Forms.Label();
            this.lblnight = new System.Windows.Forms.Label();
            this.lblguest = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.MaskedTextBox();
            this.txtGuestAge = new System.Windows.Forms.MaskedTextBox();
            this.txtNights = new System.Windows.Forms.MaskedTextBox();
            this.txtNumberOfGuests = new System.Windows.Forms.MaskedTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbladitional = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.rtbstandard = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.rbhight = new System.Windows.Forms.RadioButton();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtBookingDetails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblhotelroom
            // 
            this.lblhotelroom.AutoSize = true;
            this.lblhotelroom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblhotelroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotelroom.Location = new System.Drawing.Point(4, -1);
            this.lblhotelroom.Name = "lblhotelroom";
            this.lblhotelroom.Size = new System.Drawing.Size(1371, 58);
            this.lblhotelroom.TabIndex = 1;
            this.lblhotelroom.Text = resources.GetString("lblhotelroom.Text");
            this.lblhotelroom.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblpersonal
            // 
            this.lblpersonal.AutoSize = true;
            this.lblpersonal.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonal.Location = new System.Drawing.Point(146, 62);
            this.lblpersonal.Name = "lblpersonal";
            this.lblpersonal.Size = new System.Drawing.Size(212, 26);
            this.lblpersonal.TabIndex = 2;
            this.lblpersonal.Text = "personal Information";
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestname.Location = new System.Drawing.Point(146, 94);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(124, 26);
            this.lblguestname.TabIndex = 3;
            this.lblguestname.Text = "Guest name";
            this.lblguestname.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblguestage
            // 
            this.lblguestage.AutoSize = true;
            this.lblguestage.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestage.Location = new System.Drawing.Point(146, 136);
            this.lblguestage.Name = "lblguestage";
            this.lblguestage.Size = new System.Drawing.Size(114, 26);
            this.lblguestage.TabIndex = 4;
            this.lblguestage.Text = "Guest Age:";
            // 
            // lblnight
            // 
            this.lblnight.AutoSize = true;
            this.lblnight.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnight.Location = new System.Drawing.Point(146, 170);
            this.lblnight.Name = "lblnight";
            this.lblnight.Size = new System.Drawing.Size(183, 26);
            this.lblnight.TabIndex = 5;
            this.lblnight.Text = "Number Of Night:";
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguest.Location = new System.Drawing.Point(146, 221);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(189, 26);
            this.lblguest.TabIndex = 6;
            this.lblguest.Text = "Number Of Guest :";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(393, 92);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(182, 26);
            this.txtGuestName.TabIndex = 7;
            this.txtGuestName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtGuestName_MaskInputRejected);
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(393, 138);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(182, 26);
            this.txtGuestAge.TabIndex = 8;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(393, 172);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(182, 26);
            this.txtNights.TabIndex = 9;
            this.txtNights.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.Location = new System.Drawing.Point(393, 223);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(182, 26);
            this.txtNumberOfGuests.TabIndex = 10;
            this.txtNumberOfGuests.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtnumberofguest_MaskInputRejected);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(42, 331);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(119, 26);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Room Type";
            // 
            // lbladitional
            // 
            this.lbladitional.AutoSize = true;
            this.lbladitional.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladitional.Location = new System.Drawing.Point(13, 433);
            this.lbladitional.Name = "lbladitional";
            this.lbladitional.Size = new System.Drawing.Size(170, 26);
            this.lbladitional.TabIndex = 12;
            this.lbladitional.Text = "Aditional Option";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakfast.Location = new System.Drawing.Point(57, 487);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(359, 30);
            this.chkBreakfast.TabIndex = 13;
            this.chkBreakfast.Text = "Breakfast (10 Per Guest Per Night";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // rtbstandard
            // 
            this.rtbstandard.AutoSize = true;
            this.rtbstandard.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbstandard.Location = new System.Drawing.Point(73, 379);
            this.rtbstandard.Name = "rtbstandard";
            this.rtbstandard.Size = new System.Drawing.Size(122, 30);
            this.rtbstandard.TabIndex = 14;
            this.rtbstandard.TabStop = true;
            this.rtbstandard.Text = "Standard";
            this.rtbstandard.UseVisualStyleBackColor = true;
            this.rtbstandard.CheckedChanged += new System.EventHandler(this.rbstandard_CheckedChanged);
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnormal.Location = new System.Drawing.Point(297, 379);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(108, 30);
            this.rbnormal.TabIndex = 15;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Normal";
            this.rbnormal.UseVisualStyleBackColor = true;
            // 
            // rbhight
            // 
            this.rbhight.AutoSize = true;
            this.rbhight.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhight.Location = new System.Drawing.Point(509, 379);
            this.rbhight.Name = "rbhight";
            this.rbhight.Size = new System.Drawing.Size(90, 30);
            this.rbhight.TabIndex = 16;
            this.rbhight.TabStop = true;
            this.rbhight.Text = "Hight";
            this.rbhight.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(57, 557);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(113, 35);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(283, 553);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(535, 553);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 35);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.FormattingEnabled = true;
            this.txtBookingDetails.ItemHeight = 20;
            this.txtBookingDetails.Location = new System.Drawing.Point(607, 119);
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.Size = new System.Drawing.Size(250, 424);
            this.txtBookingDetails.TabIndex = 20;
            this.txtBookingDetails.SelectedIndexChanged += new System.EventHandler(this.rtbBookingDetails_SelectedIndexChanged);
            // 
            // lstBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 612);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.rbhight);
            this.Controls.Add(this.rbnormal);
            this.Controls.Add(this.rtbstandard);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.lbladitional);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtNumberOfGuests);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblguest);
            this.Controls.Add(this.lblnight);
            this.Controls.Add(this.lblguestage);
            this.Controls.Add(this.lblguestname);
            this.Controls.Add(this.lblpersonal);
            this.Controls.Add(this.lblhotelroom);
            this.Name = "lstBookingDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblhotelroom;
        private System.Windows.Forms.Label lblpersonal;
        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblguestage;
        private System.Windows.Forms.Label lblnight;
        private System.Windows.Forms.Label lblguest;
        private System.Windows.Forms.MaskedTextBox txtGuestName;
        private System.Windows.Forms.MaskedTextBox txtGuestAge;
        private System.Windows.Forms.MaskedTextBox txtNights;
        private System.Windows.Forms.MaskedTextBox txtNumberOfGuests;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbladitional;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.RadioButton rtbstandard;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.RadioButton rbhight;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox txtBookingDetails;
    }
}

