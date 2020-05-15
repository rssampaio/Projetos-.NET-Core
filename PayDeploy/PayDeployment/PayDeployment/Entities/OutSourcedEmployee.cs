namespace PayDeployment.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }
        public OutSourcedEmployee()
        {

        }
        public OutSourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + ( 1.1 * AditionalCharge );
        }
    }
}
