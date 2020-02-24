// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MoodAnalyzerProblem
{
    public class MoodFactory
    {
        public static HappyOrSadMood CreatehappyOrSadMood(string type)
        {
            if(type.Equals("HappyOrSadMood"))
            {
                return new HappyOrSadMood();
            }
            return null;
        }
    }
}
