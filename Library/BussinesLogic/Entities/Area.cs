using System.Collections.Generic;

namespace ManteHos.Entities
{
    public partial class Area
    {
        public Area()
        {
            Employees = new List<Employee>();
            Incidents = new List<Incident>();
        }

        public Area(string name) : this()
        {
            Name = name;
        }
    }
}
