using System.Collections.Generic;

namespace ManteHos.Entities
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
