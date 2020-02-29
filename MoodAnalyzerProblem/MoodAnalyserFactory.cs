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
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyserObject(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                if(type == null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Class_Error+"");
                }
                ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
                MoodAnalyser classObject = (MoodAnalyser)constructorInfo.Invoke(new object[] { });
                return classObject;
            }
            catch(MoodAnalyzerException ex)
            {
                return ex.msg;
                
            }
        }
        public static object CreateMoodAnalyserObject2(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Class_Error + "");
                }
                ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
                if (constructorInfoObj==null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Method_Error + "");
                }
                MoodAnalyser classObject = (MoodAnalyser)constructorInfoObj.Invoke(new object[] { "I am in sad mood" });
                return classObject;
            }
            catch (MoodAnalyzerException ex)
            {
                return ex.msg;
                
            }
        }
    }
}
