// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
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
        private string message;

        public HappyOrSadMood()
        {
        }
        public HappyOrSadMood(string mesaage)
        {
            message = mesaage;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message != null)
                {
                    if (message.Contains("sad"))
                    {
                        return "Sad";
                    }
                    else
                    {
                        if (message.Contains("happy"))
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
    }
}
