using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Master
    {
        public Master() { }

        public Master(string dni, string fullName, string phone, Area area,
                      string department)
            : base(dni, fullName, phone, area)
        {
            Department = department;
        }

    }
}
