﻿using System;

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
            return int.Parse(input);
        }
    }
}