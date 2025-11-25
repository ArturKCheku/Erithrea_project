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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public System.DateTime ReportDate { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Priority Priority { get; set; } = Priority.Low;

        [Required]
        public Status Status { get; set; } = Status.Created;
        [Required]
        public string RejectionReason { get; set; }



        public virtual Area Area { get; set; }

        [Required]
        public virtual Employee Reporter { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

    }
}
