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
            bool actual = mood.Equals(MoodFactory.CreatehappyOrSadMood("HappyOrSadMood"));
            Console.WriteLine(actual);


            Console.WriteLine();
            Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
           
            //  MethodInfo methodInfo = type.GetMethod(message);
            // Console.WriteLine(methodInfo.AnalyseMood);
           // MoodFactory m = new MoodFactory();
          

        }
    }
}
