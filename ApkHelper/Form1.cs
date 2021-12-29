using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ApkHelper.utils;

namespace ApkHelper
{
    public partial class Form1 : Form
    {
        SynchronizationContext m_SyncContext = null;
        Thread workThread = null;


        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            m_SyncContext = SynchronizationContext.Current;
            InitializeComponent();
        }

        private void tabPage1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.tbApkFilePath.Text = path;
        }

        private void tabPage1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            } 
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabPage2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabPage2_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.tbInstallApkFilePath.Text = path;
        }

        private void btnApkParse_Click(object sender, EventArgs e)
        {
            if (this.tbApkFilePath.Text.Length == 0)
            {
                MessageBox.Show("请输入完整的文件路径");
                return;
            }
            String apkFullName = this.tbApkFilePath.Text;

            //判断文件是否为*.apk后缀
            if (!FileHelper.IsExistFile(apkFullName) || FileHelper.GetExtension(apkFullName) != ".apk")
            {
                MessageBox.Show("输入路径不是一个有效的apk文件，请重新输入");
                return;
            }

            this.btnApkParse.Enabled = false;
            workThread = new Thread(new ParameterizedThreadStart(this.ApkParserThreadProc));
            workThread.Start(apkFullName);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (this.tbInstallApkFilePath.Text.Length == 0)
            {
                MessageBox.Show("请输入完整的文件路径");
                return;
            }
            String apkFullName = this.tbInstallApkFilePath.Text;

            //判断文件是否为*.apk后缀
            if (!FileHelper.IsExistFile(apkFullName) || FileHelper.GetExtension(apkFullName) != ".apk")
            {
                MessageBox.Show("输入路径不是一个有效的apk文件，请重新输入");
                return;
            }

            this.btnInstall.Enabled = false;
            this.btnInstall.Text = "安装中...";
            this.btnUninstall.Enabled = false;
            workThread = new Thread(new ParameterizedThreadStart(this.ApkInstallThreadProc));
            workThread.Start(apkFullName);
        }

        private void UpdateApkBaseInfo(object apkInfo)
        {
            if (apkInfo != null)
            {
                ApkBaseInfo var = (ApkBaseInfo)apkInfo;
                this.tbPackName.Text = var.PackageName;
                this.tbVersionName.Text = var.VersionName;
                this.tbVersionCode.Text = var.VersionCode;
                this.tbMd5.Text = var.Md5;
                this.tbFileSize.Text = var.FileSize;
                this.tbMinSdk.Text = var.MinSDKVerison;
            }
            this.btnApkParse.Enabled = true;
        }

        private void UpdateInstallProgress(object text)
        {
            this.rtbCmdDetails.AppendText((String)text);
            this.btnInstall.Text = "安装";
            this.btnInstall.Enabled = true;
            this.btnUninstall.Enabled = true;
        }

        private void UpdateUnInstallProgress(object text)
        {
            this.rtbCmdDetails.AppendText((String)text);
            this.btnInstall.Text = "卸载";
            this.btnInstall.Enabled = true;
            this.btnUninstall.Enabled = true;
        }

        private void ApkParserThreadProc(object obj)
        {
            ApkBaseInfo apkBaseInfo = new ApkBaseInfo(); 
            String apkFullName = (String)obj;
            //解析apk文件详情
            List<AndroidInfo> infoList = ApkHelper.GetManifestInfo(apkFullName);
            foreach (var info in infoList)
            {
                if (info.Name == "manifest" || info.Name == "uses-sdk")
                {
                    foreach (var setting in info.Settings)
                    {
                        switch (setting.Name)
                        {
                            case "package":
                                apkBaseInfo.PackageName = setting.Value;
                                break;
                            case "android:versionCode":
                                apkBaseInfo.VersionCode = setting.Value;
                                break;
                            case "android:versionName":
                                apkBaseInfo.VersionName = setting.Value;
                                break;
                            case "android:minSdkVersion":
                                apkBaseInfo.MinSDKVerison = setting.Value;
                                break;
                            default:
                                break;
                        }
                    }
                } 
                else
                {
                    continue;
                }
            }
            apkBaseInfo.FileSize = FileHelper.ToFileSize(FileHelper.GetFileSize(apkFullName));
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(apkFullName))
                {
                    var hash = md5.ComputeHash(stream);
                    apkBaseInfo.Md5 = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }

            m_SyncContext.Post(UpdateApkBaseInfo, apkBaseInfo);
            this.btnApkParse.Enabled = true;
        }

        private void ApkInstallThreadProc(object obj)
        {
            String apkFullName = (String)obj;
            CommandHelper commandHelper = new CommandHelper();
            String commandLine = "adb install " + (this.cbOverWritten.Checked ? "-r " : "") + apkFullName;

            m_SyncContext.Post(UpdateInstallProgress, commandHelper.RunCmd(commandLine));
        }

        private void ApkUnInstallThreadProc(object obj)
        {
            String apkFullName = (String)obj;
            CommandHelper commandHelper = new CommandHelper();
            String commandLine = "adb uninstall " + apkFullName;

            m_SyncContext.Post(UpdateUnInstallProgress, commandHelper.RunCmd(commandLine));
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (this.tbUninstallPackName.Text.Length == 0)
            {
                MessageBox.Show("请输入卸载应用的报名");
                return;
            }
            String packageName = this.tbUninstallPackName.Text;

            this.btnInstall.Enabled = false;
            this.btnInstall.Text = "卸载中...";
            this.btnUninstall.Enabled = false;
            workThread = new Thread(new ParameterizedThreadStart(this.ApkUnInstallThreadProc));
            workThread.Start(packageName);
        }
    }
}
