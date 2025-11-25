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
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key()]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Incident> Incidents { get; set; }

        [Required]
        public virtual Master Master { get; set; }

    }
}
