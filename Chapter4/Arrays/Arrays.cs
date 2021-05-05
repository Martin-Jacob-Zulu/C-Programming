using System;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] {98, 67, 78, 98, 89, 90, 77, 99, 94};

            var sum = 0;
            foreach (var studentGrade in studentGrades)
            {
                sum += studentGrade;
                
            }
            var averageGrade = sum / studentGrades.Length;
            Console.WriteLine($"The average score : {averageGrade}");

        }

    }
}
