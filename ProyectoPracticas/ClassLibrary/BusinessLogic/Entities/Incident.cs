using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Incident
    {
        public Incident() { }

        public Incident(string description, DateTime dateReported,
                        Priority priority, Status status, Shift shift,
                        Area area, Employee reporter)
        {
            Description = description;
            DateReported = dateReported;
            Priority = priority;
            Status = status;
            Shift = shift;
            Area = area;
            Reporter = reporter;
        }

    }
}
