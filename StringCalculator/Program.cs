using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace StringCalculator
{
    public class Calculator
    {
        private string[] delimiters = new[] {",", "\n"};
        private int answer;
        private List<string> negativeNumbers = new List<string>();
        
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add("3,5,3,9"));
        }
        public int Add(string input)
        {
            answer = 0;
            CheckForNegatives(input);
            if (negativeNumbers.Count > 0) ThrowNegativeNumberException(negativeNumbers);
            input = ConvertDelimitersToComma(input);
            return AddNumbersToAnswer(input);
        }

        //All numbers in the negativeNumbers list are joined using Aggregate method to create the Exception error message.
        private void ThrowNegativeNumberException(List<string> negativeNumbers)
        {
            string errorMessage = "Negatives not allowed: " + negativeNumbers.Aggregate((a, b) => a + ", " + b);
            throw new Exception(errorMessage);
        }

        //Any custom delimiters in square brackets are identified and all instances of that delimiter are converted to a comma. 
        private string ConvertDelimitersToComma(string input)
        {
            MatchCollection delimiters = Regex.Matches(input, @"\[(.+?)]");

            foreach (var match in delimiters)
            {
                input = input.Replace(match.ToString().Trim('[',']'), ",");
            }
            return input;
        }

        //Numbers are collected using regex and added to answer variable if below 1000.
        private int AddNumbersToAnswer(string input)
        {
            MatchCollection foundNumbers = Regex.Matches(input, @"[\d]+");

            foreach (var match in foundNumbers)
            {
                int number = int.Parse(match.ToString());
                if(number < 1000) answer += number;
            }
            return answer;
        }

        //Negative numbers are collected using regex and stored in the negativeNumbers List.
        private void CheckForNegatives(string input)
        {
            MatchCollection collectedNegativeNumbers = Regex.Matches(input, @"-[\d]+");
            
            foreach (var match in collectedNegativeNumbers)
            {
                negativeNumbers.Add(match.ToString());
            }
        }
    }
}