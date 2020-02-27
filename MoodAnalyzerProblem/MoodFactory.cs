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
                Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
                if (type == null)
                {
                    throw new MoodAnalyzerException();
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
        public static string MoodAnalyserReflector1(string methodName)
        {
          
            Assembly executing = Assembly.GetExecutingAssembly();

            Type type = executing.GetType("MoodAnalyzerProblem.HappyOrSadMood");
                //Console.WriteLine("Class : {0}", type.Name);
           
                // Array to store methods 
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    //Console.WriteLine("--> Method : {0}", method.Name);
                    if (method.Name.Equals(methodName))
                    {
                        return "Present the method inside class";

                    }
                    else
                    {
                    return new MoodAnalyzerException().ToString();
                    }
                }
           
            return null; 

        }
    }
}