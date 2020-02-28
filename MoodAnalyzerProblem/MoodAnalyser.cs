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
    public class MoodAnalyser
    {

        private string Message;

        public MoodAnalyser()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="mesaage"></param>
        public MoodAnalyser(string mesaage)
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
                    throw new MoodAnalyzerException(ExceptionEvents.EMPTY + "");
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
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType().Equals(((MoodAnalyser)obj).GetType()))
                return true;
            return false;
        }
    }
}