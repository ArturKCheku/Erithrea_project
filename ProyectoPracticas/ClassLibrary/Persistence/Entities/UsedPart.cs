using ManteHosLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class UsedPart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }


        public virtual Part Part { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }

    }
}
