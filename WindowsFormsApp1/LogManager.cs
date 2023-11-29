using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread.WinFormsApp
{
    public class LogManager
    {
        private static LogManager _LogManager;
        public static LogManager Default => _LogManager ?? new LogManager();

        public event EventHandler<string> OnLogAdded;

        public void Log(string message)
        {
            OnLogAdded?.Invoke(this, message);
        }
    }
}
