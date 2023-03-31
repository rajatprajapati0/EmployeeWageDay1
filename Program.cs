using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int empWagePerHour = 20;
        static void Main(string[] args)
        {
            int empPerDayHour = 0;

            Console.WriteLine("Welcome To EmployeeWage Computation Program\n");
            Random rnd = new Random();
            int checke=rnd.Next(0,3);
            
            switch(checke)
            {
                case 1:
                       Console.WriteLine("Emplyee is Present For Full Day");
                       empPerDayHour = 8;
                       break;
                case 2:
                       Console.WriteLine("Emplyee is Present For Half Day");
                       empPerDayHour = 4;
                       break; 
                default:
                        Console.WriteLine("Emplyee is Absent");
                        empPerDayHour = 0;
                    break;
            }
            int empDailyWage = empPerDayHour * empWagePerHour;
            Console.WriteLine($"Employee Daily Wage Is :{empDailyWage}$");

           Console.ReadLine();

        }
    }
}
