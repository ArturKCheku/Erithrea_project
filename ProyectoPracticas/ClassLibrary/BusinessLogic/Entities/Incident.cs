using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public Incident() { }

        public Incident(string department, string description, DateTime reportDate, 
            Priority priority, Status status, Employee reporter, Area area = null, string rejectionReason = null) : this()
        {
            
            Department = department;
            Description = description;
            ReportDate = reportDate;
            Priority = priority;
            Status = status;
            Reporter = reporter;
            //Status = Status.Created;
            //Priority = Priority.Low;
            CostOfUsedParts = 0;
            Area = area;
            RejectionReason = rejectionReason;
        }

        public Incident(string department, string description,DateTime reportDate, Employee reporter)
            : this(department, description, reportDate, Priority.Medium, Status.Created, reporter) 
        { 
        
        }

    }
}
