using ManteHos.Entities;
using ManteHosLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            UsedParts = new List<UsedPart>();
        }

        public WorkOrder(DateTime dateCreated, string description, Status status,
                         Incident incident, Employee assignedEmployee) : this()
        {
            DateCreated = dateCreated;
            Description = description;
            Status = status;
            Incident = incident;
            AssignedEmployee = assignedEmployee;
        }

    }
}
