using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "";
            var trials = 6;
            while (key != "secrete")
            {
                Console.Write("Please enter a validation key : ");
                key = Console.ReadLine();

                if (key != "secrete")
                {
                    Console.WriteLine("Authentication Failed please try again.");
                }
                trials--;
                Console.WriteLine($"{trials} remaining");
                if (trials < 1)
                {
                    Console.WriteLine("Failed to authenticate");
                    return;
                }
            }
            Console.WriteLine("Successfully Authenticated");
        }
    }
}
