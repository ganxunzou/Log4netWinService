using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using log4net;

namespace Log4netWinService
{
    public partial class Log4netWinService : ServiceBase
    {
        private Timer timerTenSecond = new Timer(10000);
        ILog log = LogManager.GetLogger(typeof(Log4netWinService));

        public Log4netWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Started - Log4netWinService");
            timerTenSecond.Elapsed += new ElapsedEventHandler(TimerTenSecond_Elapsed);
            timerTenSecond.Enabled = true;
        }
        private void TimerTenSecond_Elapsed(object sender, ElapsedEventArgs e)
        {
            log.Error("Triggered - Log4netWinService - Error");
        }


        protected override void OnStop()
        {
        }
    }
}
