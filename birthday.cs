using System;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            string birthYear = Console.ReadLine();
            Console.WriteLine("What month were you born?");
            string birthMonth = Console.ReadLine();
            Console.WriteLine("What day were you born on?");
            string birthDay = Console.ReadLine();

            DateTime userBirthDay;
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            try
            {
                int year = Int32.Parse(birthYear);
                int month = Int32.Parse(birthMonth);
                int day = Int32.Parse(birthDay);
                userBirthDay = new DateTime(year, month, day);
                Console.WriteLine($"Your Birthday is {userBirthDay}.");

                TimeSpan span = (now - userBirthDay);

                int yearsSpan = span.Days / 365;
                int leftOverDays = span.Days % 365;
                string formattedSpan = String.Format("{0} Years, {1} days, {2} hours, {3} minutes, {4} seconds",
                yearsSpan, leftOverDays, span.Hours, span.Minutes, span.Seconds);
                Console.WriteLine($"You have been alive for: {formattedSpan}");
            }
            catch
            {
                Console.WriteLine("Please enter your responses as a numeric values YYYY or MM or DD");
               
            }
        }
    }
}
