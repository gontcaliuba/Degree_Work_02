using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    public class ContactSkype
    {
        int id;
        string name;
        public ContactSkype(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
    }
}
