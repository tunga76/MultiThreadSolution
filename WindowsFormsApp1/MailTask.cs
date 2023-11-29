using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread.WinFormsApp
{
    public class MailTask : INotifyPropertyChanged
    {
        private bool _IsRunning { get; set; }
        private bool _IsStarted { get; set; }
        private int _Second { get; set; } = 60;
        private DateTime? _NextRuningTime { get; set; }


        public Guid Guid { get; set; } = Guid.NewGuid();

        public DateTime? NextRuningTime
        {
            get
            {
                return _NextRuningTime;
            }
            set
            {
                _NextRuningTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextRuningTime)));
            }
        }
        public bool IsRunning
        {
            get
            {
                return _IsRunning;
            }
            set
            {
                _IsRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
            }
        }

        public bool IsStarted
        {
            get
            {
                return _IsStarted;
            }
            set
            {
                _IsStarted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsStarted)));
            }
        }

        public int Second
        {
            get
            {
                return _Second;
            }
            set
            {
                _Second = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Second)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task Run()
        {
            while (IsRunning)
            {
                IsStarted = true;


                IsStarted = false;

                NextRuningTime = DateTime.Now.AddSeconds(Second);
                await Task.Delay(Second * 1000);
            }
        }

        public void Start()
        {
            IsStarted = true;
            NextRuningTime = DateTime.Now.AddSeconds(Second);
        }

        public void Stop()
        {
            IsStarted = false;
        }

    }
}
