using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class Name
    {
        string name = "Unnamed";
        public string Cat_name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
