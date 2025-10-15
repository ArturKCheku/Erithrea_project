using System.Collections.Generic;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        // Relaciones
        public virtual Area Area { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<Incident> ReportedIncidents { get; set; }
    }
}
