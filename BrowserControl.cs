using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    public class BrowserControl
    {
        void startProcess(string link)
        {
            Process.Start(link);
        }

        public void openForecast(string link)
        {
            startProcess(link);
        }

        public void openCalendar()
        {
            startProcess("http://days.pravoslavie.ru/docs/2016_1.html");
        }
        public void openMoonCalendar()
        {
            startProcess("http://strawberryfarm.info/moonlist.htm");
        }
        public void openNews()
        {
            startProcess("http://point.md");
        }
    }
}
