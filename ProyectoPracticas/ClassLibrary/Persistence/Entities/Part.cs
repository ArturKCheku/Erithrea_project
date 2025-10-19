using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHosLib.Entities
{
    public partial class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<UsedPart> UsedParts { get; set; }

    }
}
