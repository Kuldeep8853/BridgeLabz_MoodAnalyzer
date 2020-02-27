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
        public string Message
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
                if (Message.Contains("sad") || Message.Contains("happy"))
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
                else if(Message==null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.Null+"");
                }
                else
                {
                    throw new MoodAnalyzerException(ExceptionEvents.No_Such_Field_Error + "");
                }
            }
            catch (MoodAnalyzerException e)
            {
                return e.Message;
            }
            return null;
        }
       
    }
}