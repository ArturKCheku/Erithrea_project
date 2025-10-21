using ManteHos.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManteHos.Entities
{
    public partial class Part
    {
        public Part()
        {
            UsedParts = new List<UsedPart>();
        }

        public Part(string code, int currentQuantity, string description, int minimumQuantity, string unitOfMeasure,float unitPrice) : this()
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            CurrentQuantity = currentQuantity;
            MinimunQuantity = minimumQuantity;
            UnitOfMeasure = unitOfMeasure;
        }
    }


}
