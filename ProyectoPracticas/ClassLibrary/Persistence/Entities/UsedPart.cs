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
    public partial class UsedPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Needed { get; set; }

        [Required]
        public virtual Part Part { get; set; }

        /*[Required]
        [ForeignKey("WorkOrder")]
        public int WorkOrderId { get; set; }

        [InverseProperty("UsedParts")]
        public virtual WorkOrder WorkOrder { get; set; }
        */
    }
}
