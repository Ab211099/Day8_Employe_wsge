using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_EmpPayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage program");
            Console.WriteLine("Choose opion \n 1.Check emp abs or pres \n 2.Calculate daily wage");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: Class1.EmployeeAttendance(); break;
                case 2: Class2.CalculateDailyWage(); break;
            }
        }

    }
}
