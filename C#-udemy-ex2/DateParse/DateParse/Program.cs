using System;

namespace DateParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the dte of birth (dd.MM.YYYY)");

            string dateOfBirthString = Console.ReadLine();

            DateTime dateOfBirth = DateTime.Parse(dateOfBirthString);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;
            

            Console.WriteLine($"You were born {timeSpan.TotalDays} days ago");
        }
    }
}