// --------------------------------------------------------------------------------------------------------------------
// <copyright Project=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;

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

        public HappyOrSadMood()
        {

        }

        public HappyOrSadMood(string message)
        {
           this.Message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message != null)
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
            if (obj == null)
                return false;
            
            Console.WriteLine(obj.GetType().ToString());
            Type type = (Type)obj;
            Console.WriteLine(type.FullName.ToString());
            if (this.GetType().ToString().Equals(type.FullName))
            {
                return true;
            }
            else
                return false;
        }
    }
}
