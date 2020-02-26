using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            Type type = typeof(MoodAnalyzerProblem.HappyOrSadMood);
            ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
            Console.WriteLine(constructorInfoObj.GetType());
            Console.WriteLine(constructorInfoObj.IsPublic);
            object classObject = constructorInfoObj.Invoke(new object[] { "I am in sad mood" });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            bool actual = classObject.Equals(type1);
            Console.WriteLine(actual);


            //Console.WriteLine();
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
