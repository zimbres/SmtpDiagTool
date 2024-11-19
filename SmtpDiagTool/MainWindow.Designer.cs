namespace SmtpDiagTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.smtpServerAddress = new System.Windows.Forms.TextBox();
            this.smtpServerLabel = new System.Windows.Forms.Label();
            this.smtpServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.srvReqAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.bcc = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.testSmtpButton = new System.Windows.Forms.Button();
            this.sourceCode = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // smtpServerAddress
            // 
            this.smtpServerAddress.Location = new System.Drawing.Point(118, 25);
            this.smtpServerAddress.Name = "smtpServerAddress";
            this.smtpServerAddress.Size = new System.Drawing.Size(236, 20);
            this.smtpServerAddress.TabIndex = 0;
            // 
            // smtpServerLabel
            // 
            this.smtpServerLabel.AutoSize = true;
            this.smtpServerLabel.Location = new System.Drawing.Point(12, 28);
            this.smtpServerLabel.Name = "smtpServerLabel";
            this.smtpServerLabel.Size = new System.Drawing.Size(74, 13);
            this.smtpServerLabel.TabIndex = 1;
            this.smtpServerLabel.Text = "SMTP Server:";
            // 
            // smtpServerPort
            // 
            this.smtpServerPort.Location = new System.Drawing.Point(432, 28);
            this.smtpServerPort.Name = "smtpServerPort";
            this.smtpServerPort.Size = new System.Drawing.Size(72, 20);
            this.smtpServerPort.TabIndex = 2;
            this.smtpServerPort.Text = "25";
            this.smtpServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.smtpServerAddress);
            this.groupBox1.Controls.Add(this.smtpServerLabel);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.srvReqAuthCheckBox);
            this.groupBox1.Controls.Add(this.smtpServerPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail Server Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(15, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 47);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(378, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Kerberos";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(241, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NTLM";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User and Password (Default)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(342, 112);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(171, 20);
            this.password.TabIndex = 8;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(87, 112);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(171, 20);
            this.username.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(272, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(15, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // srvReqAuthCheckBox
            // 
            this.srvReqAuthCheckBox.AutoSize = true;
            this.srvReqAuthCheckBox.Enabled = false;
            this.srvReqAuthCheckBox.Location = new System.Drawing.Point(15, 69);
            this.srvReqAuthCheckBox.Name = "srvReqAuthCheckBox";
            this.srvReqAuthCheckBox.Size = new System.Drawing.Size(167, 17);
            this.srvReqAuthCheckBox.TabIndex = 4;
            this.srvReqAuthCheckBox.Text = "Server requires authentication";
            this.srvReqAuthCheckBox.UseVisualStyleBackColor = true;
            this.srvReqAuthCheckBox.CheckedChanged += new System.EventHandler(this.SrvReqAuthCheckBox);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.body);
            this.groupBox3.Controls.Add(this.subject);
            this.groupBox3.Controls.Add(this.bcc);
            this.groupBox3.Controls.Add(this.cc);
            this.groupBox3.Controls.Add(this.to);
            this.groupBox3.Controls.Add(this.from);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 273);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mail Settings";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(69, 204);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(416, 20);
            this.textBox11.TabIndex = 13;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(69, 97);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(416, 101);
            this.body.TabIndex = 12;
            this.body.Text = "This is a test from SMTP Diag Tool";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(69, 71);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(416, 20);
            this.subject.TabIndex = 11;
            this.subject.Text = "Test from SMTP Diag Tool";
            // 
            // bcc
            // 
            this.bcc.Enabled = false;
            this.bcc.Location = new System.Drawing.Point(309, 45);
            this.bcc.Name = "bcc";
            this.bcc.Size = new System.Drawing.Size(176, 20);
            this.bcc.TabIndex = 10;
            // 
            // cc
            // 
            this.cc.Enabled = false;
            this.cc.Location = new System.Drawing.Point(69, 45);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(176, 20);
            this.cc.TabIndex = 9;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(310, 17);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(176, 20);
            this.to.TabIndex = 8;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(69, 19);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(176, 20);
            this.from.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Attachement:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "HTML\r\nMessage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Subject:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "BCC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "From:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 561);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton);
            // 
            // testSmtpButton
            // 
            this.testSmtpButton.Location = new System.Drawing.Point(422, 561);
            this.testSmtpButton.Name = "testSmtpButton";
            this.testSmtpButton.Size = new System.Drawing.Size(122, 38);
            this.testSmtpButton.TabIndex = 7;
            this.testSmtpButton.Text = "Test SMTP";
            this.testSmtpButton.UseVisualStyleBackColor = true;
            this.testSmtpButton.Click += new System.EventHandler(this.TestSmtpButton);
            // 
            // sourceCode
            // 
            this.sourceCode.AutoSize = true;
            this.sourceCode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.sourceCode.Location = new System.Drawing.Point(163, 625);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Size = new System.Drawing.Size(237, 13);
            this.sourceCode.TabIndex = 8;
            this.sourceCode.TabStop = true;
            this.sourceCode.Tag = "https://github.com/zimbres/SmtpDiagTool";
            this.sourceCode.Text = "Copyright (c) 2024 Zimbres.COM -> Source Code";
            this.sourceCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCodeLink);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 647);
            this.Controls.Add(this.sourceCode);
            this.Controls.Add(this.testSmtpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "SMTP Diag Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox smtpServerAddress;
        private System.Windows.Forms.Label smtpServerLabel;
        private System.Windows.Forms.TextBox smtpServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox srvReqAuthCheckBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox bcc;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button testSmtpButton;
        private System.Windows.Forms.LinkLabel sourceCode;
    }
}

