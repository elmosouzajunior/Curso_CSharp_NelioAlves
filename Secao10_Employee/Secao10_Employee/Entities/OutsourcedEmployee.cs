namespace Secao10_Employee.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            ValuePerHour = valuePerHour;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + (AdditionalCharge * 1.1);
        }
    }
}
