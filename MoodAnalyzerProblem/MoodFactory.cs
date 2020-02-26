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

        public static HappyOrSadMood MoodAnalyserReflector(string classname)
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
       
    }
}