using System;

namespace ManteHos.Entities
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

