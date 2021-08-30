using System;

namespace StringCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            
        }
        public static int Add(string input)
        {
            if (String.IsNullOrEmpty(input)) return 0;
            string[] delimiters = new string[] {",", "\n"};
            string[] numbers = input.Split(delimiters, 4, StringSplitOptions.None);
            int answer = 0;
            foreach (string number in numbers)
            {
                answer += int.Parse(number);
            }
            return answer;
        }
    }
}