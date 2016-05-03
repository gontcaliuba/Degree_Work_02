using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    public class IPWorker
    {
        public string IPRequestHelper(string url)
        {
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }

        public string GetCityByIP()
        {
            string publicIP = new System.Net.WebClient().DownloadString("https://api.ipify.org");
            string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + publicIP);
            using (TextReader sr = new StringReader(ipResponse))
            {
                using (System.Data.DataSet dataBase = new System.Data.DataSet())
                {
                    dataBase.ReadXml(sr);
                    string city = dataBase.Tables[0].Rows[0][5].ToString();

                    return city;
                }
            }
        }
    }
}

