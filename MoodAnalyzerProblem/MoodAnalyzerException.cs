// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;

namespace MoodAnalyzerProblem
{
    public enum ExceptionEvents {
        EMPTY, 
        Null,
        No_Such_Class_Error,
        No_Such_Method_Error,
        No_Such_Field_Error
    };
    /// <summary>
    /// custom exception throw MoodAnalyzerException 
    /// </summary>
    [Serializable]
   public class MoodAnalyzerException: Exception
    {
        public MoodAnalyzerException() : base()
        {

        }
        /// <summary>
        /// Constructor of the custom exception
        /// </summary>
        /// <param name="Enum value"></param>
        public MoodAnalyzerException(string Err_msg ):base(Err_msg)
        {
            
        }
       
    }
}
