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

        public WorkOrder(DateTime startDate, Incident incident)
            : this()
        {
            StartDate = startDate;
            Incident = incident;
            
        }

        /*public WorkOrder(DateTime startDate, Incident incident, string repairReport = null, DateTime? endDate = null)
            : this()
        {
            StartDate = startDate;
            Incident = incident;
            RepairReport = repairReport;
            EndDate = endDate;
        }
        */      

        /*public WorkOrder(DateTime startDate, Incident incident) : this()
        {
            StartDate = startDate;
            Incident = incident;
            if(incident != null) //added
            {
                incident.WorkOrder = this; // ad
            }
        }
        */

        public void AddOperator(Operator op1)
        {
            if (!Operators.Contains(op1))
                Operators.Add(op1);

        }

        public UsedPart AddUsedPart(int quantity, Part part)
        {
            UsedPart usedPart = new UsedPart(quantity, part);
            UsedParts.Add(usedPart);
            return usedPart;
        }

    }
}