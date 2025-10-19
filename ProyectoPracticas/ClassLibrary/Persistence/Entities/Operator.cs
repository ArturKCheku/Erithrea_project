using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Operator : Employee
    {
        public string ShiftCode { get; set; }
        public Shift Shift { get; set; }

    }
}
