using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class UsedPart
    {
        public UsedPart() { }

        public UsedPart(int quantity, Part part, WorkOrder workOrder)
        {
            Quantity = quantity;
            Part = part;
            WorkOrder = workOrder;
        }

    }
}
