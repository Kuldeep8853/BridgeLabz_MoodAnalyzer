// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace MoodAnalyzerProblem
{
    public class MoodFactory
    {
        public static HappyOrSadMood CreatehappyOrSadMood(string type)
        {
            Console.WriteLine("Enter the mood message: ");
            string message = Console.ReadLine();
            if (type.Equals("HappyOrSadMood"))
            {
                return new HappyOrSadMood(message);
            }
            return null;
        }
    }
}
