internal partial class Program
{
    public class Developer: Employee
    {
        public bool TaskCompleted { get; set; }
        private const decimal Bonus = 0.03m;

        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }
        private decimal CalculateBouns()
        {
            return TaskCompleted ? Bonus * base.Calculate() : 0;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted: {(TaskCompleted?"YES":"NO")}" +
                $"\nBonus: ${Math.Round(CalculateBouns(), 2):N0}" +
                $"\nNetSallary: ${this.Calculate()}";

        }
    }
}