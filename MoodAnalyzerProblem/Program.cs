using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the mood message: ");
            string message = Console.ReadLine();
            HappyOrSadMood mood = new HappyOrSadMood();
            string Mood=mood.AnalyseMood(message);
            Console.WriteLine(Mood);
        }
    }
}
