using System;

namespace ClassLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            Console.WriteLine($"{bill.Name} {bill.GetDateOfBirth()}");

            bill.SayHi();
            bill.ContactNumber = "999888777";
            Console.WriteLine(bill.ContactNumber);

            Person john = new Person(new DateTime(1990, 1, 1), "John", "Wick");

            john.SayHi();

            Console.WriteLine(Person.Count);
        }
    }
}