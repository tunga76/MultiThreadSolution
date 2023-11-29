using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }

        private void AddLog(string logMassage)
        {

            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(logMassage)));
                return;
            }

            logMassage = $"[{DateTime.UtcNow:g}] - {logMassage}";
            lbLogs.Items.Add(logMassage);
            lbLogs.SelectedIndex = lbLogs.SelectedItems.Count - 1;
        }

        private void btnListMailTask_Click(object sender, EventArgs e)
        {
            var mailTask = new MailTask()
            {
                Second = 10
            };
            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(mailTask);
        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            btnStart.Enabled = !mailTask.IsStarted;
            btnStop.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
        }

        private void btnRunTask_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }
    }
}
