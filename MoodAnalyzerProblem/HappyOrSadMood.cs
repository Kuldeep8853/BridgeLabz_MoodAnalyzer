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
    public class HappyOrSadMood {

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
            Message = mesaage;
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
                        return "Happy";
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}
