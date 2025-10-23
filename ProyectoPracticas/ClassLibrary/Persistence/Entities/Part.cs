using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManteHos.Entities
{
    public partial class Part
    {
        [Key]
        public string Code { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float UnitPrice { get; set; }

        [Required]
        public int CurrentQuantity { get; set; }

        [Required]
        public int MinimunQuantity { get; set; }

        [Required]
        public string UnitOfMeasure { get; set; }

        public virtual ICollection<UsedPart> UsedParts { get; set; }

    }
}
