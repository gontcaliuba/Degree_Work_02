using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
   public class JsonWorker
    {
        public static string Convert(string message)
        {
            var jsons = message.Split('\n');
            string text = null;

            foreach (var j in jsons)
            {
                dynamic jsonObject = JsonConvert.DeserializeObject(j);
                if (jsonObject == null || jsonObject.result.Count <= 0) continue;

                text = jsonObject.result[0].alternative[0].transcript;
            }
            return text;
        }
    }
}
