using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names;
            names = new string[4];

            names[0] = "Ruth";
            names[1] = "Jay";
            names[2] = "Chanda";
            names[3] = "Zulu";

            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
