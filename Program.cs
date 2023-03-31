using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int workingDays = 20;
        const int empPerHourWage = 20;
        static void Main(string[] args)
        {
            int empPerDayHour = 0;
            int totalEmployeeWage = 0;
           
            Console.WriteLine("Welcome To EmployeeWage Computation Program\n");
            Random rnd = new Random();
            for(int i = 0; i < workingDays; i++) 
            {
                int checke = rnd.Next(0, 3);
                switch (checke)
                {
                    case 1:
                            empPerDayHour = 8;
                        break;
                    case 2:
                            empPerDayHour = 4;
                        break;
                    default:
                            empPerDayHour = 0;
                        break;
                }
                int empDailyWage = empPerDayHour * empPerHourWage;
                totalEmployeeWage+=empDailyWage;
            }
          
            Console.WriteLine($"Employee Monthly Wage Is :{totalEmployeeWage}$");
            Console.ReadLine();
        }
    }
}
