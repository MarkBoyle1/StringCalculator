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
            string[] numbers = input.Split(',');
            int answer = 0;
            foreach (string number in numbers)
            {
                answer += int.Parse(number);
            }
            return answer;
        }
    }
}