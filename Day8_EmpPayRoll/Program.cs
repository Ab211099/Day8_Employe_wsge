namespace Day8_EmpPayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage program");
            Console.WriteLine("Choose opion \n 1.Check emp abs or pres \n 2.Calculate daily wage \n 3.Add Part time wage \n 4.Dailywage usind case \n 5.Calculate wage for month");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: Class1.EmployeeAttendance(); break;
                case 2: Class2.CalculateDailyWage(); break;
                case 3: Class3.CalculateDailyPartTimeWage(); break;
                case 4: Class4.CalculateDailyWageUsingCase(); break;
                case 5: Class5.MonthWage(); break;
            }
        }

    }
}
