using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    [Serializable]
    public class RemindRange
    {
        XmlWorker xml = new XmlWorker();
        public List<Remind> remindList = new List<Remind>();

        public RemindRange()
        {

        }
        public RemindRange(string xmlName)
        {
            RemindRange listFromXml = xml.readXML(xmlName);
            if (listFromXml != null) remindList = listFromXml.remindList;
        }
        
        public void addRemindsInXml()
        {
            xml.writeXML("Reminds.xml", this);
        }
        public void addMessage(DateTime dateTime, string message)
        {
            remindList.Add(new Remind(remindList.Count(), dateTime, message));
        }

        public void removeMessage(int id)
        {
            if (id < 0) return;
            if (id >= remindList.Count) return;
            remindList.RemoveAt(id);
        }

        public string extractLastMessage()
        {
            return remindList[remindList.Count - 1].message;
        }

        public DateTime extractLastDateAndTime()
        {
            return remindList[remindList.Count - 1].dateTime;
        }
    }
}
