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
            xml.Load(filename);

            XmlNodeList cityList = xml.GetElementsByTagName("City");
            for (int i = 0; i < cityList.Count; i++)
            {
                string cityName = cityList[i].LastChild.InnerText;
                int cityId = Int32.Parse(cityList[i].FirstChild.InnerText);
                if (dict.ContainsKey(cityName) == true) continue;
                dict.Add(cityName, cityId);                
            }

        }

        public int getCityId(string cityName)
        {
            if (dict.ContainsKey(cityName) == false) return -1;
            return dict[cityName];
        }
    }
}
