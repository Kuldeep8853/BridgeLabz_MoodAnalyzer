using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            MoodAnalyser actual = MoodAnalyserFactory.CreateMoodAnalyserObject2("MoodAnalyzerProblem.MoodAnalyser");
           Console.WriteLine(actual);
            MoodAnalyser actual1 = MoodAnalyserFactory.CreateMoodAnalyserObject3("MoodAnalyzerProblem.MoodAnalyser");
        }
    }
}
