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

        private string Message;

        /// <summary>
        /// Default Contrucor
        /// </summary>
        public HappyOrSadMood()
        {
        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="mesaage"></param>
        public HappyOrSadMood(string mesaage)
        {
            this.Message = mesaage;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message == null)
                {
                    throw new MoodAnalyzerException(ExceptionEvents.NULL + "");
                }
                else if (this.Message == "")
                {
                    throw new MoodAnalyzerException(ExceptionEvents.EMPTY+"");
                }
                else if (this.Message.Contains("sad"))
                {
                        return "Sad";
                }
                else
                        return "Happy";
            }
            catch (MoodAnalyzerException ex)
            {
                return ex.Message;
            }
        }
    }
}