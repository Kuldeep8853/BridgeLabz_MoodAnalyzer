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
        /// test case 5.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
            Type type = typeof(MoodAnalyzerProblem.HappyOrSadMood);
            ConstructorInfo constructorInfoObj = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
            Console.WriteLine(constructorInfoObj.GetType());
            Console.WriteLine(constructorInfoObj.IsPublic);
            object classObject = constructorInfoObj.Invoke(new object[] { "I am in sad mood" });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            bool actual = classObject.Equals(type1);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 5.2
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
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 5.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("hjbdvysezbgv");
            string actual = mood.AnalyseMood();
            string expected = null;
            Assert.AreEqual(actual, expected);
        }
    }
}