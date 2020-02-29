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
        public static object CreateMoodAnalyserObject(string className, object[] ConstructorArgument = null)
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
                return ex.msg;
            }
            catch (MissingMethodException)
            {
                return ExceptionEvents.No_Such_Method_Error.ToString();
            }
        }
    }
}