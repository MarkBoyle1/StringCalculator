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
        
        [Fact]
        public void Test3()
        {
            Assert.Equal(3, Calculator.Add("1,2"));
            Assert.Equal(8, Calculator.Add("3,5"));

        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(6, Calculator.Add("1,2,3"));
            Assert.Equal(20, Calculator.Add("3,5,3,9"));

        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(6, Calculator.Add("1,2\n3"));
            Assert.Equal(20, Calculator.Add("3\n5\n3,9"));

        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(3, Calculator.Add("//;\n1;2"));
        }
    }
}
