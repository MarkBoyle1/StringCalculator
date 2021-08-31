using System;
using System.Globalization;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace StringCalculator.Tests
{
    public class UnitTest1
    {
        private Calculator _calculator = new Calculator();
        [Fact]
        public void Test1_given_InputEqualsEmptyString_when_Add_then_return_0()
        {
            Assert.Equal(0, _calculator.Add(""));
        }
        
        [Fact]
        public void Test2_given_InputHasSingleNumber_when_Add_then_return_singleNumber()
        {
            Assert.Equal(1, _calculator.Add("1"));
            Assert.Equal(3, _calculator.Add("3"));

        }
        
        [Fact]
        public void Test3_given_InputHasTwoNumbers_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(3, _calculator.Add("1,2"));
            Assert.Equal(8, _calculator.Add("3,5"));

        }

        [Fact]
        public void Test4_given_InputLengthVaries_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(6, _calculator.Add("1,2,3"));
            Assert.Equal(20, _calculator.Add("3,5,3,9"));

        }

        [Fact]
        public void Test5_given_InputContainsLineBreak_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(6, _calculator.Add("1,2\n3"));
            Assert.Equal(20, _calculator.Add("3\n5\n3,9"));

        }
        [Fact]
        public void Test6_given_CustomDelimiterProvided_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(3, _calculator.Add("//;\n1;2"));
        }
        [Fact]
        public void Test7_given_InputContainsNegativeNumbers_when_Add_then_throwException()
        {
            var ex = Assert.Throws<Exception>(() => _calculator.Add("-1,2,-3"));
            Assert.Equal("Negatives not allowed: -1, -3", ex.Message);
        }
        [Fact]
        public void Test8_given_InputContains1000And1001And2_when_Add_then_return_2()
        {
            Assert.Equal(2, _calculator.Add("1000,1001,2"));
        }
        [Fact]
        public void Test9_given_CustomDelimiterProvidedOfVaryingLength_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(6, _calculator.Add("//[***]\n1***2***3"));
        }
        [Fact]
        public void Test10_given_MultipleCustomDelimitersProvided_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(6, _calculator.Add("//[*][%]\n1*2%3"));
        }
        [Fact]
        public void Test11_given_MultipleCustomDelimitersProvidedOfVaryingLength_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(10, _calculator.Add("//[***][#][%]\n1***2#3%4"));
        }
        [Fact]
        public void Test12_given_CustomDelimitersWithNumbersInsideProvided_when_Add_then_return_SumOfNumbers()
        {
            Assert.Equal(6, _calculator.Add("//[*1*][%]\n1*1*2%3"));
        }
    }
}