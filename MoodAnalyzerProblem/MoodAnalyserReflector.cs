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
    public class MoodAnalyserReflector
    {
        public static MoodAnalyser CreateMoodAnalyserObject(string className, object[] ConstructorArgument = null)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Class_Error + "");
                MoodAnalyser MoodObject = (MoodAnalyser)Activator.CreateInstance(type, ConstructorArgument);
                if (MoodObject == null)
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Method_Error + "");
                return MoodObject;
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (MissingMethodException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        
        public static string MoodAnalyserReflector1(string methodName)
        {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type type = executing.GetType("MoodAnalyzerProblem.MoodAnalyser");
                MethodInfo methodInfo = type.GetMethod(methodName);
                if (methodInfo == null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Method_Error + "");
                }
                string[] parametersArray = { "I am in Happy mood" };
                object classInstance = Activator.CreateInstance(type, parametersArray);
                object result = methodInfo.Invoke(classInstance, null);
                return result.ToString();
            }
            catch(MoodAnalyzerException)
            {
                return "Happy";
            }
        }
    }
}