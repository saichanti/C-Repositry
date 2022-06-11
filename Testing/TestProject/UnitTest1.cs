using Xunit;
using unittesting;
using Moq;
using System;
using NUnit.Framework;


namespace unittesting
{
    public class UnitTest1
    {
        Operations operations = new Operations();
        [Fact]
        public void ClassAdd()
        {
            var a = 10;
            var b = 20;
            var result = 30;
            Xunit.Assert.Equal(result, operations.Additions(a, b));

        }
        [Fact]
        public void ClassSub()
        {
            var a = 20;
            var b = 10;
            var result = 10;
            Xunit.Assert.Equal(result, operations.Substraction(a, b));

        }
        [Fact]
        public void ClassMul()
        {
            var a = 20;
            var b = 10;
            var result = 200;
            Xunit.Assert.Equal(result, operations.Multiply(a, b));

        }
        [Fact]
        public void ClassDiv()
        {
            var a = 20;
            var b = 10;
            var result = 2;
            Xunit.Assert.Equal(result, operations.Division(a, b));

        }
    }
}