using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Operator
    {
        public Operator() { }

        public Operator(string dni, string fullName, string phone, Area area,
                        string shiftCode, Shift shift)
            : base(dni, fullName, phone, area)
        {
            ShiftCode = shiftCode;
            Shift = shift;
        }

    }
}
