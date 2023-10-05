internal partial class Program
{
    public class Mantinance : Employee
    {
        private const decimal HardShip = 100m;
        public override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }
       
        public override string ToString()
        {
            return base.ToString() +
                $"\nHardShip: ${HardShip}" +
                $"\nNetSallary: ${this.Calculate()}";

        }
    }
}