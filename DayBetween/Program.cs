using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("Enter a date (MM/DD/YYYY): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another date (MM/DD/YYYY): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            DaysBetween(date1, date2);
            Console.ReadLine();
        }
        public static double DaysBetween(DateTime userDT1, DateTime userDT2)
        {
            double daysBetween = (userDT2 - userDT1).TotalDays;           
            return daysBetween;            
        }
        // TODO: Create that has a method that counts the number of days between two different dates.
    }   
}
