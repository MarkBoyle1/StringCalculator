using System;
using System.Collections.Generic;
using System.Linq;


namespace StringCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add("//;\n1;2,3,6,7"));
        }
        public int Add(string input)
        {
            if (String.IsNullOrEmpty(input)) return 0;
            if (input.Contains("//")) 
                input = input.Replace(input[2], ',');
            string[] delimiters = new string[] {",", "\n"};
            string[] numbers = input.Split(delimiters, input.Length, StringSplitOptions.None);
            int answer = 0;
            List<string> negativeNumbers = new List<string>();
            foreach (string number in numbers)
            {
                int intNumber;
                if (int.TryParse(number, out intNumber))
                    if (int.Parse(number) < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else if(int.Parse(number) < 1000)
                    {
                        answer += int.Parse(number);
                    }
            }

            if (negativeNumbers.Count > 0) ThrowNegativeNumberException(negativeNumbers);
            return answer;
        }

        private void ThrowNegativeNumberException(List<string> negativeNumbers)
        {
            string errorMessage = "Negatives not allowed: " + negativeNumbers.Aggregate((a, b) => a + ", " + b);
            throw new Exception(errorMessage);
        }
    }
}