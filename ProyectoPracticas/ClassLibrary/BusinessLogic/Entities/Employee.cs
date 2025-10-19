using ManteHosLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            WorkOrders = new List<WorkOrder>();
            ReportedIncidents = new List<Incident>();
        }

        public Employee(string dni, string fullName, string phone, Area area) : this()
        {
            DNI = dni;
            FullName = fullName;
            Phone = phone;
            Area = area;
        }
    }

}
