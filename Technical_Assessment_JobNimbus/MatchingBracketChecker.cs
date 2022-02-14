using System;
using System.Collections.Generic;

namespace Technical_Assessment_JobNimbus
{
    public class MatchingBracketChecker
    {
        private string _input { get; }

        public bool HasMatchingBrackets => CheckForMatchingBrackets();

        public MatchingBracketChecker(string input)
        {
            _input = input;
        }

        /// <summary>
        /// Method that takes a string argument and returns whether or not characters in the string have matching brackets. Meaning for every { there is a corresponding } bracket. 
        /// </summary>
        /// <returns>
        /// True if there is a matching closing bracket for every open bracket and False if there is not a matching closing bracket for every open bracket.
        /// </returns>
        private bool CheckForMatchingBrackets()
        {
            var (openBrackets, closeBrackets) = GetListsOfOpenAndCloseBrackets();

            // If the number of open brackets does not match the number of close brackets, we can immediately assume false.
            if (openBrackets.Count != closeBrackets.Count)
                return false;

            for (var i = 0; i < openBrackets.Count; i++)
            {
                // Compare each open bracket position with the matching close bracket position and return false if the close bracket position is before the open bracket position
                if (openBrackets[i] > closeBrackets[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Returns a list of open bracket's indicies and a list of close bracket's indicies in a tuple
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private Tuple<List<int>, List<int>> GetListsOfOpenAndCloseBrackets()
        {
            List<int> openBrackets = new();
            List<int> closeBrackets = new();

            for (var i = 0; i < _input.Length; i++)
            {
                if (_input[i] == '{')
                    openBrackets.Add(i);
                if (_input[i] == '}')
                    closeBrackets.Add(i);
            }

            return Tuple.Create(openBrackets, closeBrackets);
        }
    }
}
