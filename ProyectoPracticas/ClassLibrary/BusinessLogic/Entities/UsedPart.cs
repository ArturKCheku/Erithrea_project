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
            Needed = Part.MinimunQuantity > Part.CurrentQuantity - quantity;
            if(!Needed) Part.CurrentQuantity -= quantity;

        }

        public UsedPart(bool needed,  WorkOrder workOrder):this()
        {
            //Quantity = quantity;
            //Needed = needed;
            //Part = part;
            //WorkOrder = workOrder;
        }

    }
}
