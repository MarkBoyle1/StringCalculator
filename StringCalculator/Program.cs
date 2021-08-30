using System;

namespace StringCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("//;\n1;2"));
        }
        public static int Add(string input)
        {
            if (String.IsNullOrEmpty(input)) return 0;
            char[] charArray = input.ToCharArray();
            if (input.Contains("//")) 
                input = input.Replace(charArray[2], ',');
            string[] delimiters = new string[] {",", "\n"};
            string[] numbers = input.Split(delimiters, input.Length, StringSplitOptions.None);
            int answer = 0;
            foreach (string number in numbers)
            {
                int intNumber;
                if(int.TryParse(number, out intNumber))
                    answer += int.Parse(number);
            }
            return answer;
        }
    }
}