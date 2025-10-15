using System;
using System.Collections.Generic;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

        public virtual Incident Incident { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
        public virtual ICollection<UsedPart> UsedParts { get; set; }
    }
}
