internal partial class Program
{
    public class Sales : Employee
    {
        public decimal SalesVolume { get; set; }
        public decimal CommissionRate { get; set; }
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            return SalesVolume * CommissionRate;

        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommission: ${Math.Round(CommissionRate,2):N0}" +
                $"\nBonus: ${Math.Round(CalculateBonus(),2):N0}" +
                $"\nNetSallary: ${this.Calculate()}";

        }
    }
}