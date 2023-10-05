using System;
using System.Linq;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Manager manager =new Manager()
        {
            Id = 1000,
            Name = "Ahmed",
            LoggedHours = 176,
            wage = 10
        };
        Mantinance mantinance = new Mantinance()
        {
            Id = 1001,
            Name = "Ali",
            LoggedHours = 185,
            wage = 9
        };
       
        Developer developer = new Developer()
        {
            Id = 1002,
            Name = "Yahia",
            LoggedHours = 180,
            wage = 14,
            TaskCompleted = true
        };
        Sales sales = new Sales()
        {
            Id = 1003,
            Name = "Amer",
            LoggedHours = 177,
            wage = 8,
            CommissionRate = 0.05m,
            SalesVolume = 10000
        };
        Employee[] employees= new Employee[] { manager, mantinance, developer, sales };
        foreach (var employee in employees)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(employee);
        }

        for(; ; )
        {
            Console.ReadKey();
        }
    }
}