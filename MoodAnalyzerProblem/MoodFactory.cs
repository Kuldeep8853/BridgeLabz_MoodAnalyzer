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

                return new HappyOrSadMood("I am in sad mood");

            return null;

        }

        public static Type CreateHappyOrSadMoodUsingReflection(string classname)
        {
            try
            {
                Type type = Type.GetType(classname);
                if (type == null)
                {
                    throw new MoodAnalyzerException("exception caught class name");
                }
                return type;
            }
            catch (MoodAnalyzerException ex)
            {
                return null;
            }
        }

    }
}
