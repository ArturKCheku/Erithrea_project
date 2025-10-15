namespace ManteHos.Entities
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
