using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            HappyOrSadMood result = MoodFactory.MoodAnalyserReflector("MoodAnalyzerProblem.HappyOrSadMood");
            Console.WriteLine(result.AnalyseMood() + " Mood");
            Console.WriteLine(MoodFactory.MoodAnalyserReflector1("xbtsnfgnx"));


            //Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.Namespace);

            //  MethodInfo methodInfo = type.GetMethod(message);
            // Console.WriteLine(methodInfo.AnalyseMood);
            // MoodFactory m = new MoodFactory();


        }
    }
}
