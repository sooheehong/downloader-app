using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DownloaderApp
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<string> result)
        {
            InitializeComponent();

            textBox1.Text = string.Join(Environment.NewLine, result);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
