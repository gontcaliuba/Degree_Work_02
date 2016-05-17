using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DegreeWork_01
{
    public class XmlWorker
    {
        public string extractLink(int idTown)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("http://informer.gismeteo.ru/rss/" + idTown + ".xml");
            XmlNodeList xnList = xml.SelectNodes("/rss/channel/item/link");
            string link = xnList[0].InnerText;
            return link;
        }
        public RemindRange readXML(string xmlName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(RemindRange));
            RemindRange newRange = null;
            try
            {
                using (FileStream fs = new FileStream(xmlName, FileMode.Open))
                {
                    newRange = (RemindRange)formatter.Deserialize(fs);
                }
            }
            catch
            {
                return null;
            }
            return newRange;
        }
        public void writeXML(string xmlName, RemindRange newRange)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(RemindRange));
            using (FileStream fs = new FileStream(xmlName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, newRange);
            }
        }
    }
}