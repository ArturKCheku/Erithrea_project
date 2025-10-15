using System.Collections.Generic;

namespace ManteHos.Entities
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
