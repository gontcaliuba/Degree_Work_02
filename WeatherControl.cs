using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    public class WeatherControl
    {
            IPWorker ipW = new IPWorker();
            XmlWorker xml = new XmlWorker();
            public string getLinkForForcast()
            {
                string city = ipW.GetCityByIP();
                TownsDatabase db = new TownsDatabase("Cities.xml");
                int id = db.getCityId(city);
                string link = xml.extractLink(id);

                return link;
            }
    }
}
