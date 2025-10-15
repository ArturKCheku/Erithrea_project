namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public UsedPart() { }

        public UsedPart(int quantity, Part part, WorkOrder workOrder)
        {
            Quantity = quantity;
            Part = part;
            WorkOrder = workOrder;
        }
    }
}
