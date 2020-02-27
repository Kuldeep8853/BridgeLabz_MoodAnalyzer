using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            MoodAnalyser actual = MoodAnalyserFactory.CreateMoodAnalyserObject2("MoodAnalyzerProblem.MoodAnalyser"); ;
           Console.WriteLine(actual);
        }
    }
}
