using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskService;

namespace TaskWinform
{
    public partial class Form1 : Form
    {
        private bool _isStarted;

        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                MessageBox.Show("任务正在执行中。。。");
            }
            else
            {
                TaskTest.Instance.Init();
                _isStarted = true;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                TaskTest.Instance.Stop();
                _isStarted = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            else
            {
                MessageBox.Show("任务已停止。。。");
            }
        }
    }
}
