using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RepairReport { get; set; }

        // Relación con Incident
        public virtual Incident Incident { get; set; }

        // Relación con UsedPart (composición)
        public virtual ICollection<UsedPart> UsedParts { get; set; }

        // Relación con Operator
        public virtual ICollection<Operator> Operators { get; set; }
    }
}
