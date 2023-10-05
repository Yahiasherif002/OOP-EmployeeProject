internal partial class Program
{
    public class Employee
    {
        const int minLoggedHours=176;
        const decimal overtime=1.25m;
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal LoggedHours { get; set; }

        public  decimal wage { get; set; }

        private decimal CalculateBsicSalary()
        {
            return minLoggedHours * wage;
        }   
        private decimal CalculateOvertimeSalary()
        {
            var additionalHours = ((LoggedHours - minLoggedHours)>0? LoggedHours - minLoggedHours:0); 
            int overtimeSalary = (int)(additionalHours * overtime * wage);
            return overtimeSalary;
        }
        public virtual decimal Calculate()
        {
            return CalculateBsicSalary() + CalculateOvertimeSalary();   
        }
        public override string ToString()
        {
            var type = this.GetType().Name;
            return $"{type}," +
                   $"\nId: {Id}," +
                   $"\nName: {Name}," +
                   $"\nLoggedHours: {LoggedHours}hrs," +
                   $"\nWage: {wage}$," +
                   $"\nBase Salary: {Math.Round( CalculateBsicSalary(),2):N0}$," +
                   $"\nOvertime Salary: {Math.Round(CalculateOvertimeSalary(),2):N0}$,";
                   
        }
    }
}