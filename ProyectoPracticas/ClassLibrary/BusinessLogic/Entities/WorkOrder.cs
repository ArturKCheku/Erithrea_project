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

        public WorkOrder(DateTime startDate, Incident incident) : this()
        {
            StartDate = startDate;
            Incident = incident;
        }

        public void AddOperator(Operator op)
        {
            if (Operators == null)
                Operators = new List<Operator>();

            if (!Operators.Contains(op))
            {
                Operators.Add(op);

                if (op.WorkOrders == null)
                    op.WorkOrders = new List<WorkOrder>();
                op.WorkOrders.Add(this);
            }
        }

        public void AddUsedPart(int quantity, Part part)
        {
            if (UsedParts == null)
                UsedParts = new List<UsedPart>();

            var usedPart = new UsedPart(quantity, part);
            UsedParts.Add(usedPart);
        }
    }
}