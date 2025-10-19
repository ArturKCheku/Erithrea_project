using ManteHosLib.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManteHosLib.Entities
{
    public partial class Part
    {
        public Part()
        {
            UsedParts = new List<UsedPart>();
        }

        public Part(string name, string reference, int stock) : this()
        {
            Name = name;
            Reference = reference;
            Stock = stock;
        }
    }


}
