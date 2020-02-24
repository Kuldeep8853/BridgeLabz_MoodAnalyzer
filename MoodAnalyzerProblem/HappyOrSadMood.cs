// --------------------------------------------------------------------------------------------------------------------
// <copyright Project=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;

namespace MoodAnalyzerProblem
{
    /// <summary>
    /// Check mood sad or happy
    /// </summary>
    public class HappyOrSadMood
    {
        private string Message
        {
            get;
            set;
        }
        public HappyOrSadMood(string message)
        {
            this.Message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (Message != null)
                {
                    if (Message.Contains("sad"))
                    {
                        return "Sad";
                    }
                    else
                    {
                        if (Message.Contains("happy"))
                            return "Happy";
                    }
                }
                else
                {
                    throw new MoodAnalyzerException("null exception caught");
                }
            }
            catch (MoodAnalyzerException e)
            {
                return e.Message;
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            Type type = Type.GetType("MoodAnalyzerProblem.HappyOrSadMood");
            Console.WriteLine(obj.GetType().ToString());
            Console.WriteLine(type.FullName.ToString());
            if (type.FullName.ToString().Equals(obj.GetType().ToString()))
                return true;
            else
                return false;
        }
    }
}
