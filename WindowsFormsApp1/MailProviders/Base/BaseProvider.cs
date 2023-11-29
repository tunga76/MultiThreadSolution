using MultiThread.WinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread.WinFormsApp.MailProviders.Base
{
    public abstract class BaseProvider
    {
        public int Port { get; set; } = 587;
        public string ServerHostName { get; set; } = "smtp.google.com.tr";
        public abstract Task Send(MailModel mailModel);
    }
}
