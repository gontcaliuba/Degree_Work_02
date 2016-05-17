using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    [Serializable]
    public class Remind
    {
        public int id;
        public DateTime dateTime;
        public string message;

        public Remind()
        {
        }
        public Remind(int id, DateTime dateTime, string message)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.message = message;
        }
    }
}
