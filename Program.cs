using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreeWork_01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkypeControl skype = new SkypeControl();
            SystemControl system = new SystemControl();
            
            //skype.startSkype();

            //skype.call("gontcal");

            //skype.videoCall("gontcal");

            //skype.stopSkype();

            /*
            system.makeScreenImage();
            system.openFolderIm();
            */

            //system.reloadSystem();

            //system.shutdownSystem();

            //Process.Start("https://www.gismeteo.md/city/daily/4980/");

            /*XmlWorker xml = new XmlWorker();
            string link = xml.extractLink(33815);
            Process.Start(link);*/

            IPWorker ipW = new IPWorker();
            string city = ipW.GetCityByIP();

            Application.Run(new Form1());
            
            
        }
    }
}
