using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace AppCursoXamarin
{
    public class Maquinaria: NotificationObject
    {
        private System.Timers.Timer timer;
        private string hh;

        public string HH
        {
            get { return hh; }
            set
            {
                hh = value;
                OnPropertyChanged();
            }
        }

        private string mm;     

        public string MM
        {
            get { return mm; }
            set
            {
                mm = value;
                OnPropertyChanged();
            }
        }

        private string ss;

        public string SS
        {
            get { return ss; }
            set
            {
                ss = value;
                OnPropertyChanged();
            }
        }

        public Maquinaria()
        {
            Timer t = new Timer();
            t.Elapsed += new ElapsedEventHandler(ActualizarReloj);
            t.Start();
        }

        private void ActualizarReloj(object sender, ElapsedEventArgs e)
        {
            HH = e.SignalTime.Hour.ToString();
            MM = e.SignalTime.Minute.ToString();
            SS = e.SignalTime.Second.ToString();
        }
    }
}
