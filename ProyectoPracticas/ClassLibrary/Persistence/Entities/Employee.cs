using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }


        public virtual Area Area { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<Incident> ReportedIncidents { get; set; }

    }
}
