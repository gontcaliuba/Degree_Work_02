using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DegreeWork_01
{
    class RemindControl
    {
        Timer timer = new Timer(1000 * 5);
        RemindRange remindRange = null;

        public RemindControl(RemindRange remindRange)
        {
            this.remindRange = remindRange;
            timer.Elapsed += timerEvent;
            timer.Start();
        }

        void timerEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (remindRange == null) return;

            for (int i = 0; i < remindRange.remindList.Count; ++i)
            {
                Remind remind = remindRange.remindList[i];
                DateTime current_time = DateTime.Now;
                DateTime remind_time = remind.dateTime;
                TimeSpan delta = current_time - remind_time;
                if ((delta.Seconds >= 0) && (delta.Seconds < 60))
                {
                    System.Windows.Forms.MessageBox.Show(remind.message);
                    remindRange.remindList.RemoveAt(i);
                }
            }
        }
    }
}
