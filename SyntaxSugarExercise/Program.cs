using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var answer = int.Parse(Console.ReadLine());
            
            var response = (answer > 9) ? $"{answer} is higher than 9!" : $"{answer} is lower than 9!";

            Console.WriteLine(response);

        }
    }
}
