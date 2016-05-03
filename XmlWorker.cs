using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
    }
}