using System;
using System.Collections.Generic;

namespace ManteHos.Entities
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
