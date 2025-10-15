namespace ManteHos.Entities
{
    public partial class Operator : Employee
    {
        public string ShiftCode { get; set; }
        public Shift Shift { get; set; }
    }
}
