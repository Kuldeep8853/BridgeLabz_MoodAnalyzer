using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
           Console.WriteLine(MoodAnalyserReflector.ChangeMoodDynamically("Improper_Message"));
        }

    }
}
