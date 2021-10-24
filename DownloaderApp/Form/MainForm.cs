using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloaderApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void anonymousCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (anonymousCheck.Checked)
            {
                idText.ReadOnly = true;
                pwText.ReadOnly = true;
            }
            else
            {
                idText.ReadOnly = false;
                pwText.ReadOnly = false;
            }
        }

        private void ftpBrowsetn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ftpLocalPathText.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var host = ftpAddrText.Text;
            int.TryParse(ftpPortText.Text, out var port);
            var remotePath = ftpRemotePathText.Text;
            var id = "anonymous";
            var pw = "anonymous";
            var localPath = ftpLocalPathText.Text;

            if (!anonymousCheck.Checked)
            {
                id = idText.Text;
                pw = pwText.Text;

                if (string.IsNullOrWhiteSpace(id))
                {
                    ShowErrorMessage("Id를 입력해주세요");
                    return;
                }
                if (string.IsNullOrWhiteSpace(pw))
                {
                    ShowErrorMessage("Password를 입력해주세요");
                    return;
                }
            }

            if (!Directory.Exists(localPath))
            {
                ShowErrorMessage("다운로드 경로가 존재하지 않습니다.");
                return;
            }

            FTPManager manager = new FTPManager(id, pw, host, port);

            if (!manager.IsConnect())
            {
                ShowErrorMessage("접속에 실패하였습니다. 접속정보를 확인해주세요.");
                return;
            }

            // TODO : Progress bar...
            try
            {
                var result = manager.FtpDownload(remotePath, localPath, true);
                if (result.Any())
                {
                    MessageBox.Show("완료!", "DownloaderApp");
                    ShowResultForm(result);
                }
                else
                {
                    MessageBox.Show("완료! 다운로드 할 파일이 없습니다", "DownloaderApp");
                }
            }
            catch
            {
                ShowErrorMessage("다운로드에 실패하였습니다");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                httpLocalPathText.Text = dialog.FileName;
            }

        }

        private void httpOkBtn_Click(object sender, EventArgs e)
        {
            var addr = httpAddrText.Text;
            var localPath = httpLocalPathText.Text;

            if (string.IsNullOrWhiteSpace(addr))
            {
                ShowErrorMessage("HTTP 접속 정보를 확인해주세요.");
                return;
            }

            if (!Directory.Exists(localPath))
            {
                ShowErrorMessage("다운로드 경로가 존재하지 않습니다.");
                return;
            }

            if (!HTTPManager.IsWebExists(addr))
            {
                ShowErrorMessage("해당 파일이 존재하지 않습니다. 접속정보를 확인해주세요.");
                return;
            }

            try
            {
                var result = HTTPManager.HttpDownload(addr, localPath);
                MessageBox.Show("완료!", "DownloaderApp");
                ShowResultForm(new List<string> { result });
            }
            catch
            {
                ShowErrorMessage("다운로드에 실패하였습니다");
            }
        }

        private void ftpPortText_KeyPress(object sender, KeyPressEventArgs e)
        {    
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void ShowErrorMessage(string msg)
        {
            MessageBox.Show(msg, "DownloadApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowResultForm(List<string> result)
        {
            result.Sort();

            var resultFrom = new ResultForm(result);
            resultFrom.ShowDialog();
        }
    }
}
