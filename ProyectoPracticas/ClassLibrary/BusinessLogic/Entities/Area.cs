using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManteHos.Entities
{
    public partial class Area 
    {
        public Area()
        {
            Incidents = new List<Incident>();
        }

        public Area(string name, Master master) : this()
        {
            Name = name;
            Master = master;
            
        }
    }

}
