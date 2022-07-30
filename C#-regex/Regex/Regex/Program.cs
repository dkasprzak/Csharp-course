using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[a-z0-9]+\.?[a-z0-9]+@[a-z]+\.[a-z]{2,3}$");

            string email = "example.mail12@mail.com";

            bool isMatch = regex.IsMatch(email);

            Console.WriteLine(isMatch);
        }
    }
}