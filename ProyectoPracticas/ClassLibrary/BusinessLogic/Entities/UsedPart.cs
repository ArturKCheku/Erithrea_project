using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public UsedPart() { }

        public UsedPart(int quantity, Part part) {
            Quantity = quantity;
            Part = part;

        }

        public UsedPart(bool needed,  WorkOrder workOrder):this()
        {
            //Quantity = quantity;
            Needed = true;
            //Part = part;
            WorkOrder = workOrder;
        }

    }
}
