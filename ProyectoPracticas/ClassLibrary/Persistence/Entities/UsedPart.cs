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
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key()]
        public int Id { get; set; }

        
        public int Quantity { get; set; }

        
        public bool Needed { get; set; }

        [Required]
        public virtual Part Part { get; set; }

        
    }
}
