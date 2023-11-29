using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread.WinFormsApp.Models
{
    public class MailModel
    {
        public string To { get; set; }
        public string From { get; set; } = "hikmettunga@gmail.com";
        public MailProviderType ProviderType { get; set; }
    }

    public enum MailProviderType
    {
        Smtp = 1
    }
}
