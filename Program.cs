using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int fullDay = 1;
        const int halfDay = 2;
        const int empWagePerHour = 20;
        static void Main(string[] args)
        {
            int empPerDayHour = 0;

            Console.WriteLine("Welcome To EmployeeWage Computation Program\n");
            Random rnd = new Random();
            int checke=rnd.Next(0,3);
            
            if (checke==fullDay)
            {
                Console.WriteLine("Emplyee is Present For Full Day");
                empPerDayHour = 8;
            }
            else if (checke == halfDay)
            {
                Console.WriteLine("Emplyee is Present For Half Day");
                empPerDayHour = 4;
            }
            else
            {
                Console.WriteLine("Emplyee is Absent");
                empPerDayHour = 0;
                
            }

            int empDailyWage = empPerDayHour * empWagePerHour;
            Console.WriteLine($"Employee Daily Wage Is :{empDailyWage}$");

            Console.ReadLine();

        }
    }
}
