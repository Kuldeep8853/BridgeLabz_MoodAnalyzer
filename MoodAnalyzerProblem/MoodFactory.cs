// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    public class MoodFactory
    {
        public static HappyOrSadMood CreatehappyOrSadMood(string type)
        {

            if (type.Equals("HappyOrSadMood"))

                return new HappyOrSadMood();

            return null;

        }

        public static HappyOrSadMood CreateHappyOrSadMoodUsingReflection(string classname)
        {
            try
            {
                Type type = Type.GetType(classname);
                if (type == null)
                {
                    throw new MoodAnalyzerException("exception caught class name");
                }
                ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
                HappyOrSadMood classObject = (HappyOrSadMood)constructorInfoObj.Invoke(new object[] { "I am in happy mood" });
                //classObject.AnalyseMood();
                return classObject;
                
            }
            catch (MoodAnalyzerException ex)
            {
                 throw ex;
            }
        }
        public static string MoodAnalyserReflector(string method)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
                ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
                HappyOrSadMood classObject = (HappyOrSadMood)constructorInfoObj.Invoke(new object[] { "I am in happy mood" });
                MethodInfo methodInfo = type.GetMethod(method);
                return methodInfo.GetMethodBody().ToString();
            }
            catch( MoodAnalyzerException)
            {
                return new MoodAnalyzerException("No Such Method Error").ToString();
            }
        }

    }
}