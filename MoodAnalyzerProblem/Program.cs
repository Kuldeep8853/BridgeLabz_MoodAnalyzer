﻿using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the mood message: ");
            string message = Console.ReadLine();
            HappyOrSadMood mood = new HappyOrSadMood(null);
            string Mood=mood.AnalyseMood();
            Console.WriteLine(Mood);
        }
    }
}
