using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
            object classObject = constructorInfo.Invoke(new object[] { });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            bool actual = classObject.Equals(type1);
            Console.WriteLine(actual);


            /*//Console.WriteLine("Enter the mood message: ");
            //string message = Console.ReadLine();
            HappyOrSadMood mood = new HappyOrSadMood();
            bool actual = mood.Equals(MoodFactory.CreatehappyOrSadMood("HappyOrSadMood"));
            Console.WriteLine(actual);*/

            //Console.WriteLine();
            //Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.Namespace);

            //  MethodInfo methodInfo = type.GetMethod(message);
            // Console.WriteLine(methodInfo.AnalyseMood);
            // MoodFactory m = new MoodFactory();

            //HappyOrSadMood mood = new HappyOrSadMood();
            //Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            //bool actual = mood.Equals(type);
            //Console.WriteLine(actual);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(mood);
            //Console.WriteLine(type.Namespace);

        }
    }
}
