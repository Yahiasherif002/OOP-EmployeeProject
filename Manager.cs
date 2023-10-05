internal partial class Program
{
    public class Manager : Employee
    {
        private const decimal AllowanceRate=0.05m;
        public override decimal Calculate()
        {
            return base.Calculate()+CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return AllowanceRate * base.Calculate();

        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance: ${CalculateAllowance()}" +
                $"\nNetSallary: ${this.Calculate()}";

        }
    }   
}