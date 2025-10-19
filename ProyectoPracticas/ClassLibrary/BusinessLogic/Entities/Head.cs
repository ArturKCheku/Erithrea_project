using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Head
    {
        public Head() { }

        public Head(string dni, string fullName, string phone, Area area,
                    string office)
            : base(dni, fullName, phone, area)
        {
            Office = office;
        }

    }
}
