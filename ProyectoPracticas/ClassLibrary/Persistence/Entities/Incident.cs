using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string RejectionReason { get; set; } = null;

        
        public float CostOfUsedParts { get; set; } = 0;

        [InverseProperty("Incidents")]
        public virtual Area Area { get; set; }

        [Required]
        [InverseProperty("ReportedIncidents")]
        public virtual Employee Reporter { get; set; }

        [InverseProperty("Incident")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
