using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManteHos.Entities
{
    public partial class Area
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key()]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [InverseProperty("Area")]
        public virtual ICollection<Incident> Incidents { get; set; }

        [Required]
        [InverseProperty("Area")]
        public virtual Master Master { get; set; }

    }
}
