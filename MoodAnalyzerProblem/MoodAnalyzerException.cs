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
    /// Define enum collection of exception events
    /// </summary>
    public enum ExceptionEvents
    {
        EMPTY,
        NULL,
        No_Such_Class_Error,
        No_Such_Method_Error,
        Parameter_Count_Mismatch
    }
    /// <summary>
    /// custom exception throw MoodAnalyzerException 
    /// </summary>
    [Serializable]
    public class MoodAnalyzerException : Exception
    {
        public string msg;

        /// <summary>
        /// parameterized constructor of the custom exception
        /// </summary>
        /// <param name="Message"></param>
        public MoodAnalyzerException(string Message)
        {
            this.msg = Message;
        }
    }
}