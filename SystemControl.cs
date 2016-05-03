using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace DegreeWork_01
{
   public class SystemControl
    {
       public void makeScreenImage()
       {
           String name = "";
           Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);
           Graphics graphics = Graphics.FromImage(printscreen as Image);
           graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
           name = DateTime.Now.ToString();
           printscreen.Save(@"D:\ScreenIm\printScre.jpg", ImageFormat.Jpeg);
       }

       public void reloadSystem()
       {
           System.Diagnostics.Process.Start("shutdown", "/r /t 0");
       }

       public void shutdownSystem()
       {
           System.Diagnostics.Process.Start("shutdown", "/s /t 0");
       }

       public void changeLanguage(string param)
       {
           if (param == "ru")
               InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
           else if (param == "en")
               InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
           else if (param == "ro")
               InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ro-RO"));
           else return;
       }

       public void openFolderIm()
       {
           System.Diagnostics.Process.Start("explorer", "D:\\ScreenIm");
       }
    }
}
