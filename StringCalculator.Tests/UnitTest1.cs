using System;
using System.Globalization;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace StringCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, Calculator.Add(""));
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Equal(1, Calculator.Add("1"));
            Assert.Equal(3, Calculator.Add("3"));

        }
    }
}