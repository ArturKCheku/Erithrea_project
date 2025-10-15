namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        // Relaciones
        public virtual Part Part { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
