
namespace DownloaderApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ftpTab = new System.Windows.Forms.TabPage();
            this.ftpOkBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ftpBrowseBtn = new System.Windows.Forms.Button();
            this.ftpLocalPathText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ftpRemotePathText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ftpPortText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anonymousCheck = new System.Windows.Forms.CheckBox();
            this.pwText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.ftpAddrText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.httpTab = new System.Windows.Forms.TabPage();
            this.httpOkBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.httpBrowseBtn = new System.Windows.Forms.Button();
            this.httpLocalPathText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.httpAddrText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ftpTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.httpTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ftpTab);
            this.tabControl1.Controls.Add(this.httpTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // ftpTab
            // 
            this.ftpTab.BackColor = System.Drawing.Color.White;
            this.ftpTab.Controls.Add(this.ftpOkBtn);
            this.ftpTab.Controls.Add(this.groupBox2);
            this.ftpTab.Controls.Add(this.groupBox1);
            this.ftpTab.Location = new System.Drawing.Point(4, 24);
            this.ftpTab.Name = "ftpTab";
            this.ftpTab.Padding = new System.Windows.Forms.Padding(3);
            this.ftpTab.Size = new System.Drawing.Size(553, 334);
            this.ftpTab.TabIndex = 0;
            this.ftpTab.Text = "FTP";
            // 
            // ftpOkBtn
            // 
            this.ftpOkBtn.Location = new System.Drawing.Point(456, 296);
            this.ftpOkBtn.Name = "ftpOkBtn";
            this.ftpOkBtn.Size = new System.Drawing.Size(75, 23);
            this.ftpOkBtn.TabIndex = 2;
            this.ftpOkBtn.Text = "Download";
            this.ftpOkBtn.UseVisualStyleBackColor = true;
            this.ftpOkBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ftpBrowseBtn);
            this.groupBox2.Controls.Add(this.ftpLocalPathText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "다운로드 경로";
            // 
            // ftpBrowseBtn
            // 
            this.ftpBrowseBtn.Location = new System.Drawing.Point(414, 32);
            this.ftpBrowseBtn.Name = "ftpBrowseBtn";
            this.ftpBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.ftpBrowseBtn.TabIndex = 2;
            this.ftpBrowseBtn.Text = "Browse..";
            this.ftpBrowseBtn.UseVisualStyleBackColor = true;
            this.ftpBrowseBtn.Click += new System.EventHandler(this.ftpBrowsetn_Click);
            // 
            // ftpLocalPathText
            // 
            this.ftpLocalPathText.Location = new System.Drawing.Point(89, 32);
            this.ftpLocalPathText.Name = "ftpLocalPathText";
            this.ftpLocalPathText.Size = new System.Drawing.Size(319, 23);
            this.ftpLocalPathText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loacl Path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpRemotePathText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ftpPortText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.anonymousCheck);
            this.groupBox1.Controls.Add(this.pwText);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.ftpAddrText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP 접속 정보";
            // 
            // ftpRemotePathText
            // 
            this.ftpRemotePathText.Location = new System.Drawing.Point(89, 52);
            this.ftpRemotePathText.Name = "ftpRemotePathText";
            this.ftpRemotePathText.Size = new System.Drawing.Size(400, 23);
            this.ftpRemotePathText.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Remote Path";
            // 
            // ftpPortText
            // 
            this.ftpPortText.Location = new System.Drawing.Point(414, 23);
            this.ftpPortText.Name = "ftpPortText";
            this.ftpPortText.Size = new System.Drawing.Size(75, 23);
            this.ftpPortText.TabIndex = 8;
            this.ftpPortText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftpPortText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Port";
            // 
            // anonymousCheck
            // 
            this.anonymousCheck.AutoSize = true;
            this.anonymousCheck.Location = new System.Drawing.Point(89, 140);
            this.anonymousCheck.Name = "anonymousCheck";
            this.anonymousCheck.Size = new System.Drawing.Size(91, 19);
            this.anonymousCheck.TabIndex = 6;
            this.anonymousCheck.Text = "Anonymous";
            this.anonymousCheck.UseVisualStyleBackColor = true;
            this.anonymousCheck.CheckedChanged += new System.EventHandler(this.anonymousCheck_CheckedChanged);
            // 
            // pwText
            // 
            this.pwText.Location = new System.Drawing.Point(89, 110);
            this.pwText.Name = "pwText";
            this.pwText.PasswordChar = '*';
            this.pwText.Size = new System.Drawing.Size(400, 23);
            this.pwText.TabIndex = 5;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(89, 81);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(400, 23);
            this.idText.TabIndex = 4;
            // 
            // ftpAddrText
            // 
            this.ftpAddrText.Location = new System.Drawing.Point(89, 23);
            this.ftpAddrText.Name = "ftpAddrText";
            this.ftpAddrText.Size = new System.Drawing.Size(284, 23);
            this.ftpAddrText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // httpTab
            // 
            this.httpTab.Controls.Add(this.httpOkBtn);
            this.httpTab.Controls.Add(this.groupBox4);
            this.httpTab.Controls.Add(this.groupBox3);
            this.httpTab.Location = new System.Drawing.Point(4, 24);
            this.httpTab.Name = "httpTab";
            this.httpTab.Padding = new System.Windows.Forms.Padding(3);
            this.httpTab.Size = new System.Drawing.Size(553, 334);
            this.httpTab.TabIndex = 1;
            this.httpTab.Text = "HTTP";
            this.httpTab.UseVisualStyleBackColor = true;
            // 
            // httpOkBtn
            // 
            this.httpOkBtn.Location = new System.Drawing.Point(458, 227);
            this.httpOkBtn.Name = "httpOkBtn";
            this.httpOkBtn.Size = new System.Drawing.Size(75, 23);
            this.httpOkBtn.TabIndex = 2;
            this.httpOkBtn.Text = "Download";
            this.httpOkBtn.UseVisualStyleBackColor = true;
            this.httpOkBtn.Click += new System.EventHandler(this.httpOkBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.httpBrowseBtn);
            this.groupBox4.Controls.Add(this.httpLocalPathText);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(13, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 92);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "다운로드 경로";
            // 
            // httpBrowseBtn
            // 
            this.httpBrowseBtn.Location = new System.Drawing.Point(430, 42);
            this.httpBrowseBtn.Name = "httpBrowseBtn";
            this.httpBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.httpBrowseBtn.TabIndex = 5;
            this.httpBrowseBtn.Text = "Browse..";
            this.httpBrowseBtn.UseVisualStyleBackColor = true;
            this.httpBrowseBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // httpLocalPathText
            // 
            this.httpLocalPathText.Location = new System.Drawing.Point(86, 42);
            this.httpLocalPathText.Name = "httpLocalPathText";
            this.httpLocalPathText.Size = new System.Drawing.Size(338, 23);
            this.httpLocalPathText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loacl Path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.httpAddrText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 88);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HTTP 접속 정보";
            // 
            // httpAddrText
            // 
            this.httpAddrText.Location = new System.Drawing.Point(86, 39);
            this.httpAddrText.Name = "httpAddrText";
            this.httpAddrText.Size = new System.Drawing.Size(419, 23);
            this.httpAddrText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "URL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 365);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Downloader App";
            this.tabControl1.ResumeLayout(false);
            this.ftpTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.httpTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ftpTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox anonymousCheck;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox ftpAddrText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage httpTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ftpBrowseBtn;
        private System.Windows.Forms.TextBox ftpLocalPathText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ftpOkBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button httpBrowseBtn;
        private System.Windows.Forms.TextBox httpLocalPathText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox httpAddrText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button httpOkBtn;
        private System.Windows.Forms.TextBox ftpPortText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ftpRemotePathText;
        private System.Windows.Forms.Label label8;
    }
}

