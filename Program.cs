using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int present = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Computation Program");
           Random rnd = new Random();
           int checke=rnd.Next(0,2);
            
            if (checke==present)
            {
                Console.WriteLine("Emplyee is Present");
            }
            else
            {
                Console.WriteLine("Emplyee is Absent");

            }

        }
    }
}
