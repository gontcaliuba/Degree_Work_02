using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DegreeWork_01
{
    class TownsDatabase
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        public TownsDatabase(string filename)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("Cities.xml");

        }

        public int getCityId(string cityName)
        {
            if (dict.ContainsKey(cityName) == false) return -1;
            return dict[cityName];
        }
    }
}
