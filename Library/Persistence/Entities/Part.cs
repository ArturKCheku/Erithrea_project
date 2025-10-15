using System.Collections.Generic;

namespace ManteHos.Entities
{
    public partial class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public int Stock { get; set; }

        // Relaciones
        public virtual ICollection<UsedPart> UsedParts { get; set; }
    }
}
