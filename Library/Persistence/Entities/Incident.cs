using System;
using System.Collections.Generic;

namespace ManteHos.Entities
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
