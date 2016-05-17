using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

            

           /* IPWorker ipW = new IPWorker();
            string city = ipW.GetCityByIP();

            TownsDatabase db = new TownsDatabase("Cities.xml");
            int id = db.getCityId(city);

            XmlWorker xml = new XmlWorker();
            string link = xml.extractLink(id);

            BrowserControl brc = new BrowserControl();
            brc.openCalendar();
            brc.openForecast(link);
            brc.openMoonCalendar();
            brc.openNews();
            * */

            /*RemindRange range = new RemindRange("Reminds.xml");
            range.addMessage(new DateTime(2016,5,9,23,06,0), "hi");

            RemindControl remC = new RemindControl(range);*/

            Application.Run(new Form1());
            //Application.Run(new Form2());

            var stream = new MemoryStream(File.ReadAllBytes("01.wav"));
            string result = SpeechRecognizer.WavStreamToGoogle(stream);
            string command = JsonWorker.Convert(result);

            Engine eng = new Engine();
            eng.commandsHandler(command);


            /*ContactList cl = new ContactList();
            cl.extractContacts();
            var contacts = cl.getContacts();*/
            
            
        }
    }
}
