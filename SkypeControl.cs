using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;
using System.Windows.Forms;
using System.Threading;

namespace DegreeWork_01
{
   public class SkypeControl
    {
       Skype skype = new Skype();
       public bool startSkype()
       {
           try
           {
               if (!skype.Client.IsRunning)
               {
                   skype.Client.Start(true, true);
                   Thread.Sleep(10000);
               }
               skype.Attach(skype.Protocol, true);
               return true;
           }
           catch
           {
               return false;
           }
       }
       bool tryCall(string name, bool isVideo)
       {
           if (!startSkype()) return false;
           Call call = skype.PlaceCall(name);
           do
           {
               if (call.Status == TCallStatus.clsBusy
                  || call.Status == TCallStatus.clsCancelled
                  || call.Status == TCallStatus.clsFailed
                  || call.Status == TCallStatus.clsMissed
                  || call.Status == TCallStatus.clsRefused)
                   return false;

               Thread.Sleep(10);
           } while (call.Status != TCallStatus.clsInProgress);

           if (isVideo == true) call.StartVideoSend();

           return true;
       }
      public void call(string name)
       {
           while (tryCall(name, false) == false)
           {
               Console.WriteLine("Подождите, устанавливается связь");
           }
       }

       public void videoCall(string name)
      {
          while (tryCall(name, true) == false)
          {
              Console.WriteLine("Подождите, устанавливается связь");
          }
      }
       public void stopSkype()
       {
           if (skype.Client.IsRunning)
               skype.Client.Shutdown();
       }

    }
}
