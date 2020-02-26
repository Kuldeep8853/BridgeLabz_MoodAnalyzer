// --------------------------------------------------------------------------------------------------------------------
// <copyright Project=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using MoodAnalyzerProblem;
using NUnit.Framework;
using System;
using System.Reflection;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// test case 4.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
            Type type = typeof(MoodAnalyzerProblem.HappyOrSadMood);
            ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
            object classObject = constructorInfoObj.Invoke(new object[] { "I am in sad mood" });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            bool actual = classObject.Equals(type1);
            Console.WriteLine(actual);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.2
        /// Throw exception 
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest()
        {
            Type type = typeof(MoodAnalyzerProblem.HappyOrSadMood);
            ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
            object classObject = constructorInfoObj.Invoke(new object[] { "I am in sad mood" });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("Wrong class name");
            bool actual = classObject.Equals(type1);
            Console.WriteLine(actual);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("mxbvyusgvjcbka");
            string actual = mood.AnalyseMood();
            string expected = null;
            Assert.AreEqual(actual, expected);
        }
    }
}