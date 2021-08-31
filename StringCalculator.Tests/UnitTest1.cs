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
        public void Test1()
        {
            Assert.Equal(0, _calculator.Add(""));
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Equal(1, _calculator.Add("1"));
            Assert.Equal(3, _calculator.Add("3"));

        }
        
        [Fact]
        public void Test3()
        {
            Assert.Equal(3, _calculator.Add("1,2"));
            Assert.Equal(8, _calculator.Add("3,5"));

        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(6, _calculator.Add("1,2,3"));
            Assert.Equal(20, _calculator.Add("3,5,3,9"));

        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(6, _calculator.Add("1,2\n3"));
            Assert.Equal(20, _calculator.Add("3\n5\n3,9"));

        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(3, _calculator.Add("//;\n1;2"));
        }
        [Fact]
        public void Test7()
        {
            var ex = Assert.Throws<Exception>(() => _calculator.Add("-1,2,-3"));
            Assert.Equal("Negatives not allowed: -1, -3", ex.Message);
        }
        [Fact]
        public void Test8()
        {
            Assert.Equal(2, _calculator.Add("1000,1001,2"));
        }
        [Fact]
        public void Test9()
        {
            Assert.Equal(6, _calculator.Add("//[***]\n1***2***3"));
        }
        [Fact]
        public void Test10()
        {
            Assert.Equal(6, _calculator.Add("//[*][%]\n1*2%3"));
        }
    }
}