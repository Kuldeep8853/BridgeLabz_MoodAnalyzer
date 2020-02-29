using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            MoodAnalyser actual =(MoodAnalyser) MoodAnalyserFactory.CreateMoodAnalyserObject2("MoodAnalyzerProblem.MoodAnalyser");
           Console.WriteLine(actual);
        }
    }
}
