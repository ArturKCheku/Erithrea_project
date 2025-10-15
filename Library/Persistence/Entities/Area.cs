using System.Collections.Generic;

namespace ManteHos.Entities
{
    public partial class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relaciones
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
