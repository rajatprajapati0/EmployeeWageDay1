using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int present = 1;
        const int empWagePerHour = 20;
        static void Main(string[] args)
        {
            int empPerDayHour = 0;

            Console.WriteLine("Welcome To EmployeeWage Computation Program\n");
            Random rnd = new Random();
            int checke=rnd.Next(0,2);
            
            if (checke==present)
            {
                Console.WriteLine("Emplyee is Present");
                empPerDayHour = 8;
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
