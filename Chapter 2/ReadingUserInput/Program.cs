using System;

namespace ReadingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("What is your year of birth: ");
            string birthYear = Console.ReadLine();
            Console.Write("What month were you born: ");
            string month = Console.ReadLine();

            int age = 2021 - int.Parse(birthYear);

            Console.WriteLine($"Hello {name}, You are {age}years old, and you were born in {month}.");
        }
    }
}
