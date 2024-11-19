namespace SmtpDiagTool
{
    partial class LogWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWindow));
            this.logMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logMessages
            // 
            this.logMessages.Location = new System.Drawing.Point(12, 39);
            this.logMessages.Multiline = true;
            this.logMessages.Name = "logMessages";
            this.logMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logMessages.Size = new System.Drawing.Size(776, 361);
            this.logMessages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP Connection Log";
            // 
            // clearLogs
            // 
            this.clearLogs.Location = new System.Drawing.Point(713, 415);
            this.clearLogs.Name = "clearLogs";
            this.clearLogs.Size = new System.Drawing.Size(75, 23);
            this.clearLogs.TabIndex = 2;
            this.clearLogs.Text = "Clear Logs";
            this.clearLogs.UseVisualStyleBackColor = true;
            this.clearLogs.Click += new System.EventHandler(this.ClearLogs);
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogWindow";
            this.Text = "SMTP Diag Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox logMessages;
        private Label label1;
        private Button clearLogs;
    }
}