using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            UsedParts = new List<UsedPart>();
            Operators = new List<Operator>();
        }
        
        public WorkOrder(DateTime startDate, Incident incident): this()
        {
            StartDate = startDate;
            //RepairReport = repairReport;
            Incident = incident;
        }

    }
}
