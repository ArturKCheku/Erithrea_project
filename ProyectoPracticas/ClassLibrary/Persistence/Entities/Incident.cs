using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Incident
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public Shift Shift { get; set; }


        public virtual Area Area { get; set; }
        public virtual Employee Reporter { get; set; }

    }
}
