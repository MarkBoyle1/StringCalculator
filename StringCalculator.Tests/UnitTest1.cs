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
    }
}