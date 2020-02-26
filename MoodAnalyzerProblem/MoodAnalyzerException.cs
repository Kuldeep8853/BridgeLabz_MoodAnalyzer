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
    /// custom exception throw MoodAnalyzerException 
    /// </summary>
    [Serializable]
   public class MoodAnalyzerException: Exception
    { 
        private string err_msg;

        /// <summary>
        /// Constructor of the custom exception
        /// </summary>
        /// <param name="err"></param>
        public MoodAnalyzerException( string err)            
        {
            err_msg = err;
        }

        public override string Message
        {
            get
            {
                return err_msg;
            }
        }
       
    }
}
