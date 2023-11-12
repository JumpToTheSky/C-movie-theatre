namespace LogInDemo
{
    partial class buyTicketFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyTicketFrm));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyTicketBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelPurBttn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.midFlw = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mTime = new System.Windows.Forms.Label();
            this.mDate = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.Label();
            this.mSub = new System.Windows.Forms.Label();
            this.mPrice = new System.Windows.Forms.Label();
            this.mDir = new System.Windows.Forms.Label();
            this.mLen = new System.Windows.Forms.Label();
            this.mFormat = new System.Windows.Forms.Label();
            this.mTotal = new System.Windows.Forms.Label();
            this.unselectBttn = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(736, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "VND";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1293, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "VND";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price:";
            // 
            // buyTicketBttn
            // 
            this.buyTicketBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTicketBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.buyTicketBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyTicketBttn.FlatAppearance.BorderSize = 0;
            this.buyTicketBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicketBttn.ForeColor = System.Drawing.Color.White;
            this.buyTicketBttn.Location = new System.Drawing.Point(1190, 105);
            this.buyTicketBttn.Name = "buyTicketBttn";
            this.buyTicketBttn.Size = new System.Drawing.Size(168, 40);
            this.buyTicketBttn.TabIndex = 26;
            this.buyTicketBttn.Text = "Purchase";
            this.buyTicketBttn.UseVisualStyleBackColor = false;
            this.buyTicketBttn.Click += new System.EventHandler(this.buyTicketBttn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Term of Payment:";
            // 
            // cbPayment
            // 
            this.cbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "Visa",
            "Momo",
            "Paypal",
            "Enthernet Banking"});
            this.cbPayment.Location = new System.Drawing.Point(1046, 13);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(312, 33);
            this.cbPayment.TabIndex = 34;
            this.cbPayment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Movie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Subtitle:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Format:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Director:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Length:";
            // 
            // cancelPurBttn
            // 
            this.cancelPurBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelPurBttn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelPurBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelPurBttn.FlatAppearance.BorderSize = 0;
            this.cancelPurBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPurBttn.Location = new System.Drawing.Point(1037, 105);
            this.cancelPurBttn.Name = "cancelPurBttn";
            this.cancelPurBttn.Size = new System.Drawing.Size(147, 40);
            this.cancelPurBttn.TabIndex = 47;
            this.cancelPurBttn.Text = "Cancel";
            this.cancelPurBttn.UseVisualStyleBackColor = false;
            this.cancelPurBttn.Click += new System.EventHandler(this.cancelPurBttn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.midFlw);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Location = new System.Drawing.Point(12, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1340, 822);
            this.panel5.TabIndex = 51;
            // 
            // midFlw
            // 
            this.midFlw.BackColor = System.Drawing.Color.DarkGray;
            this.midFlw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midFlw.Location = new System.Drawing.Point(0, 31);
            this.midFlw.Name = "midFlw";
            this.midFlw.Size = new System.Drawing.Size(1340, 791);
            this.midFlw.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1340, 31);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "SCREEN";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.WordWrap = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Time Start:";
            // 
            // mTime
            // 
            this.mTime.AutoSize = true;
            this.mTime.Location = new System.Drawing.Point(126, 83);
            this.mTime.Name = "mTime";
            this.mTime.Size = new System.Drawing.Size(75, 25);
            this.mTime.TabIndex = 54;
            this.mTime.Text = "label13";
            // 
            // mDate
            // 
            this.mDate.AutoSize = true;
            this.mDate.Location = new System.Drawing.Point(126, 52);
            this.mDate.Name = "mDate";
            this.mDate.Size = new System.Drawing.Size(75, 25);
            this.mDate.TabIndex = 55;
            this.mDate.Text = "label14";
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Location = new System.Drawing.Point(126, 21);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(75, 25);
            this.mName.TabIndex = 56;
            this.mName.Text = "label15";
            // 
            // mSub
            // 
            this.mSub.AutoSize = true;
            this.mSub.Location = new System.Drawing.Point(126, 114);
            this.mSub.Name = "mSub";
            this.mSub.Size = new System.Drawing.Size(75, 25);
            this.mSub.TabIndex = 57;
            this.mSub.Text = "label16";
            // 
            // mPrice
            // 
            this.mPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPrice.AutoSize = true;
            this.mPrice.Location = new System.Drawing.Point(605, 114);
            this.mPrice.Name = "mPrice";
            this.mPrice.Size = new System.Drawing.Size(75, 25);
            this.mPrice.TabIndex = 61;
            this.mPrice.Text = "label17";
            // 
            // mDir
            // 
            this.mDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mDir.AutoSize = true;
            this.mDir.Location = new System.Drawing.Point(605, 21);
            this.mDir.Name = "mDir";
            this.mDir.Size = new System.Drawing.Size(75, 25);
            this.mDir.TabIndex = 60;
            this.mDir.Text = "label18";
            // 
            // mLen
            // 
            this.mLen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLen.AutoSize = true;
            this.mLen.Location = new System.Drawing.Point(605, 52);
            this.mLen.Name = "mLen";
            this.mLen.Size = new System.Drawing.Size(75, 25);
            this.mLen.TabIndex = 59;
            this.mLen.Text = "label19";
            // 
            // mFormat
            // 
            this.mFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mFormat.AutoSize = true;
            this.mFormat.Location = new System.Drawing.Point(605, 83);
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(75, 25);
            this.mFormat.TabIndex = 58;
            this.mFormat.Text = "label20";
            // 
            // mTotal
            // 
            this.mTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTotal.AutoSize = true;
            this.mTotal.Location = new System.Drawing.Point(1106, 49);
            this.mTotal.Name = "mTotal";
            this.mTotal.Size = new System.Drawing.Size(0, 25);
            this.mTotal.TabIndex = 62;
            this.mTotal.Click += new System.EventHandler(this.label21_Click);
            // 
            // unselectBttn
            // 
            this.unselectBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unselectBttn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.unselectBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.unselectBttn.FlatAppearance.BorderSize = 0;
            this.unselectBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unselectBttn.Location = new System.Drawing.Point(861, 105);
            this.unselectBttn.Name = "unselectBttn";
            this.unselectBttn.Size = new System.Drawing.Size(170, 40);
            this.unselectBttn.TabIndex = 63;
            this.unselectBttn.Text = "Load - Reload";
            this.unselectBttn.UseVisualStyleBackColor = false;
            this.unselectBttn.Click += new System.EventHandler(this.unselectBttn_Click);
            // 
            // buyTicketFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 1000);
            this.Controls.Add(this.unselectBttn);
            this.Controls.Add(this.mTotal);
            this.Controls.Add(this.mPrice);
            this.Controls.Add(this.mDir);
            this.Controls.Add(this.mLen);
            this.Controls.Add(this.mFormat);
            this.Controls.Add(this.mSub);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.mDate);
            this.Controls.Add(this.mTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cancelPurBttn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buyTicketBttn);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "buyTicketFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buyTicketFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buyTicketFrm_FormClosing);
            this.Load += new System.EventHandler(this.buyTicketFrm_Load);
            this.StyleChanged += new System.EventHandler(this.buyTicketFrm_StyleChanged);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buyTicketBttn;
        private Label label2;
        private ComboBox cbPayment;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button cancelPurBttn;
        private Panel panel5;
        private FlowLayoutPanel midFlw;
        private Label label12;
        private Label mTime;
        private Label mDate;
        private Label mName;
        private Label mSub;
        private Label mPrice;
        private Label mDir;
        private Label mLen;
        private Label mFormat;
        private Label mTotal;
        private TextBox textBox3;
        private Button unselectBttn;
    }
}