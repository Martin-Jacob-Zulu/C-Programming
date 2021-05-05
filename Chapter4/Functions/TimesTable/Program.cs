using System;
using static System.Console;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTimesTable();
        }

        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                    $"{row} x {number} = {row * number}"
                );
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {

                Write("Enter a number between 0 and 255 : ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Write("You have enteres an incorrect number");
                }
            }
            while (isNumber);
        }
    }
}
