using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Operator
    {
        public Operator() {
            WorkOrders = new List<WorkOrder>();
        }

        public Operator(string fullName, string id, string password, Shift shift) : base(fullName, id, password)
        {
            Shift = shift;
            WorkOrders = new List<WorkOrder>();
        }

    }
}
