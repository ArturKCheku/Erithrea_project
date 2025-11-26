using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        
        public string FullName { get; set; }

        
        [Key]
        public string Id { get; set; }

       
        public string Password { get; set; }

        [InverseProperty("Reporter")]
        public virtual ICollection<Incident> ReportedIncidents { get; set; }

    }
}
