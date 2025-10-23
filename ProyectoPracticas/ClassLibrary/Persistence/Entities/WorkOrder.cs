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
    public partial class WorkOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RepairReport { get; set; }

        [Required]
        public virtual Incident Incident { get; set; }

        [InverseProperty("WorkOrder")]
        public virtual ICollection<UsedPart> UsedParts { get; set; }

        public virtual ICollection<Operator> Operators { get; set; }
    }
}
