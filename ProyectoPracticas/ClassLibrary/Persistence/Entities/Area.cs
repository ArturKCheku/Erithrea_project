using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }

    }
}
