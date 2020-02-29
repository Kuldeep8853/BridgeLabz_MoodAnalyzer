
using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            object MoodReflectionObject = MoodAnalyserFactory.CreateMoodAnalyserObject("Wrong class name");
            MoodAnalyser mood = new MoodAnalyser("I am in Happy mood");
            bool actual = mood.Equals(MoodReflectionObject);
            Console.WriteLine(actual);

        }
    }
}
