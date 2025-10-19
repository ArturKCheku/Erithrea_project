using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManteHosLib.Entities
{
    public partial class Area : Master
    {
        public Area()
        {
            Employees = new List<Employee>();
            Incidents = new List<Incident>();
        }

        public Area(string name, int id) : this()
        {
            Name = name;
            Id = id;
        }
    }

}
