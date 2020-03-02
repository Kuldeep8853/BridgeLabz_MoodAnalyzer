using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main()
        {
            Type theType = Type.GetType("MoodAnalyzerProblem.MoodAnalyser");
            Console.WriteLine("\nSingle Type is {0}\n", theType);
            MemberInfo[] mbrInfoArray = theType.GetMembers();
            foreach (MemberInfo mbrInfo in mbrInfoArray)
            {
                Console.WriteLine("{0}			{1}", mbrInfo.MemberType, mbrInfo.Name);
            }
        }

    }
}
