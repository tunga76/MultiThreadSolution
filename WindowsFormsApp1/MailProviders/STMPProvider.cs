using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiThread.WinFormsApp.MailProviders.Base;
using MultiThread.WinFormsApp.Models;

namespace MultiThread.WinFormsApp.MailProviders
{
    public class STMPProvider : BaseProvider
    {
        public override async Task Send(MailModel mailModel)
        {
            await Task.Delay(10);
            LogManager.Default.Log($"STMP Mail has send to {mailModel.To}");
        }
    }
}
