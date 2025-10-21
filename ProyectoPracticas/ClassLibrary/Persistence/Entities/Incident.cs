using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public int Id { get; set; }
        public System.DateTime ReportDate { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; } = Priority.Low;
        public Status Status { get; set; } = Status.Created;
        public string RejectionReason { get; set; }
        public float CostOfUsedParts { get; set; } = 0;

        // Relación con Area
        public virtual Area Area { get; set; }

        // Relación con Employee (Reporter)
        public virtual Employee Reporter { get; set; }

        // Relación con WorkOrder
        public virtual WorkOrder WorkOrder { get; set; }

    }
}
