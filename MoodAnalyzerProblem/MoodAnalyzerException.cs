﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;

namespace MoodAnalyzerProblem
{
    public enum ExceptionEvents
    {
        EMPTY,
        NULL
    }
    /// <summary>
    /// custom exception throw MoodAnalyzerException 
    /// </summary>
    [Serializable]
    public class MoodAnalyzerException : Exception
    {
        /// <summary>
        /// Default Constructor of the custom exception
        /// </summary>
        public MoodAnalyzerException() : base()
        {

        }
        /// <summary>
        /// parameterized constructor of the custom exception
        /// </summary>
        /// <param name="Enum value"></param>
        public MoodAnalyzerException(string Message) : base(Message)
        {

        }

    }
}
