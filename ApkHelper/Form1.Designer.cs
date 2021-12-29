namespace ApkHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbMinSdk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMd5 = new System.Windows.Forms.TextBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.tbVersionCode = new System.Windows.Forms.TextBox();
            this.tbVersionName = new System.Windows.Forms.TextBox();
            this.tbPackName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApkFilePath = new System.Windows.Forms.TextBox();
            this.btnApkParse = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbCmdDetails = new System.Windows.Forms.RichTextBox();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUninstallPackName = new System.Windows.Forms.TextBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.cbOverWritten = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInstallApkFilePath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.tbMinSdk);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tbMd5);
            this.tabPage1.Controls.Add(this.tbFileSize);
            this.tabPage1.Controls.Add(this.tbVersionCode);
            this.tabPage1.Controls.Add(this.tbVersionName);
            this.tabPage1.Controls.Add(this.tbPackName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbApkFilePath);
            this.tabPage1.Controls.Add(this.btnApkParse);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apk基本属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            // 
            // tbMinSdk
            // 
            this.tbMinSdk.Location = new System.Drawing.Point(216, 304);
            this.tbMinSdk.Name = "tbMinSdk";
            this.tbMinSdk.ReadOnly = true;
            this.tbMinSdk.Size = new System.Drawing.Size(337, 25);
            this.tbMinSdk.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min SDK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApkHelper.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(578, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbMd5
            // 
            this.tbMd5.Location = new System.Drawing.Point(216, 267);
            this.tbMd5.Name = "tbMd5";
            this.tbMd5.ReadOnly = true;
            this.tbMd5.Size = new System.Drawing.Size(337, 25);
            this.tbMd5.TabIndex = 12;
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(216, 234);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.ReadOnly = true;
            this.tbFileSize.Size = new System.Drawing.Size(337, 25);
            this.tbFileSize.TabIndex = 11;
            // 
            // tbVersionCode
            // 
            this.tbVersionCode.Location = new System.Drawing.Point(216, 201);
            this.tbVersionCode.Name = "tbVersionCode";
            this.tbVersionCode.ReadOnly = true;
            this.tbVersionCode.Size = new System.Drawing.Size(337, 25);
            this.tbVersionCode.TabIndex = 10;
            // 
            // tbVersionName
            // 
            this.tbVersionName.Location = new System.Drawing.Point(216, 167);
            this.tbVersionName.Name = "tbVersionName";
            this.tbVersionName.ReadOnly = true;
            this.tbVersionName.Size = new System.Drawing.Size(337, 25);
            this.tbVersionName.TabIndex = 9;
            // 
            // tbPackName
            // 
            this.tbPackName.Location = new System.Drawing.Point(216, 134);
            this.tbPackName.Name = "tbPackName";
            this.tbPackName.ReadOnly = true;
            this.tbPackName.Size = new System.Drawing.Size(337, 25);
            this.tbPackName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "MD5值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "文件大小";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "内部版本号(versionCode)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "版本号(versionName)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "包名(packageName)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入文件路径：(或将文件拖入当前窗口)";
            // 
            // tbApkFilePath
            // 
            this.tbApkFilePath.Location = new System.Drawing.Point(33, 55);
            this.tbApkFilePath.Name = "tbApkFilePath";
            this.tbApkFilePath.Size = new System.Drawing.Size(477, 25);
            this.tbApkFilePath.TabIndex = 1;
            // 
            // btnApkParse
            // 
            this.btnApkParse.Location = new System.Drawing.Point(533, 54);
            this.btnApkParse.Name = "btnApkParse";
            this.btnApkParse.Size = new System.Drawing.Size(75, 26);
            this.btnApkParse.TabIndex = 0;
            this.btnApkParse.Text = "解析";
            this.btnApkParse.UseVisualStyleBackColor = true;
            this.btnApkParse.Click += new System.EventHandler(this.btnApkParse_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.rtbCmdDetails);
            this.tabPage2.Controls.Add(this.btnUninstall);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbUninstallPackName);
            this.tabPage2.Controls.Add(this.btnInstall);
            this.tabPage2.Controls.Add(this.cbOverWritten);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbInstallApkFilePath);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "安装&卸载";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragDrop);
            this.tabPage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragEnter);
            // 
            // rtbCmdDetails
            // 
            this.rtbCmdDetails.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbCmdDetails.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbCmdDetails.Location = new System.Drawing.Point(33, 181);
            this.rtbCmdDetails.Name = "rtbCmdDetails";
            this.rtbCmdDetails.ReadOnly = true;
            this.rtbCmdDetails.Size = new System.Drawing.Size(698, 198);
            this.rtbCmdDetails.TabIndex = 10;
            this.rtbCmdDetails.Text = "";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(505, 130);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 9;
            this.btnUninstall.Text = "卸载";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "应用卸载(输入待卸载apk包名)";
            // 
            // tbUninstallPackName
            // 
            this.tbUninstallPackName.Location = new System.Drawing.Point(33, 128);
            this.tbUninstallPackName.Name = "tbUninstallPackName";
            this.tbUninstallPackName.Size = new System.Drawing.Size(451, 25);
            this.tbUninstallPackName.TabIndex = 6;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(603, 54);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "安装";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // cbOverWritten
            // 
            this.cbOverWritten.AutoSize = true;
            this.cbOverWritten.Location = new System.Drawing.Point(491, 58);
            this.cbOverWritten.Name = "cbOverWritten";
            this.cbOverWritten.Size = new System.Drawing.Size(89, 19);
            this.cbOverWritten.TabIndex = 4;
            this.cbOverWritten.Text = "覆盖安装";
            this.cbOverWritten.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "应用安装(将应用拖入当前窗口或手工输入apk全路径)";
            // 
            // tbInstallApkFilePath
            // 
            this.tbInstallApkFilePath.Location = new System.Drawing.Point(33, 54);
            this.tbInstallApkFilePath.Name = "tbInstallApkFilePath";
            this.tbInstallApkFilePath.Size = new System.Drawing.Size(451, 25);
            this.tbInstallApkFilePath.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Android工具集（Bravye Huang）";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApkFilePath;
        private System.Windows.Forms.Button btnApkParse;
        private System.Windows.Forms.TextBox tbMd5;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.TextBox tbVersionCode;
        private System.Windows.Forms.TextBox tbVersionName;
        private System.Windows.Forms.TextBox tbPackName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMinSdk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUninstallPackName;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.CheckBox cbOverWritten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInstallApkFilePath;
        private System.Windows.Forms.RichTextBox rtbCmdDetails;
    }
}

