namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual Part Part { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
