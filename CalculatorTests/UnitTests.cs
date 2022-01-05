using System;
using Xunit;

namespace CalculatorTests
{
    public class UnitTests
    {
        [Fact]
        public void SumTest()
        {
            string expression = "5+5";
            string result = "10";
            string testing = CalculatorLogic.Calculations.Calculate(expression);
            Assert.Equal(result, testing);
        }

        [Fact]
        public void SubTest()
        {
            string expression = "5-5";
            string result = "0";
            string testing = CalculatorLogic.Calculations.Calculate(expression);
            Assert.Equal(result, testing);
        }

        [Fact]
        public void MultTest()
        {
            string expression = "5*5";
            string result = "25";
            string testing = CalculatorLogic.Calculations.Calculate(expression);
            Assert.Equal(result, testing);
        }

        [Fact]
        public void DivTest()
        {
            string expression = "5/5";
            string result = "1";
            string testing = CalculatorLogic.Calculations.Calculate(expression);
            Assert.Equal(result, testing);
        }

        [Fact]
        public void ComplexExpressionTest()
        {
            string expression = "5/5+3*8/9-2-10+23/4";
            double result = -2.58;
            double testing = double.Parse(CalculatorLogic.Calculations.Calculate(expression));
            testing = Math.Round(testing, 2);
            Assert.Equal(result, testing);
        }

        [Fact]
        public void ZeroDivTest()
        {
            string expression = "5/0";
            Assert.Throws<Exception>(() => CalculatorLogic.Calculations.Calculate(expression));
        }

        [Fact]
        public void IncorrectInputTest1()
        {
            string expression = "abc";
            Assert.Throws<Exception>(() => CalculatorLogic.Calculations.Calculate(expression));
        }

        [Fact]
        public void IncorrectInputTest2()
        {
            string expression = "5+a";
            Assert.Throws<Exception>(() => CalculatorLogic.Calculations.Calculate(expression));
        }

        [Fact]
        public void IncorrectInputTest3()
        {
            string expression = "5+";
            Assert.Throws<Exception>(() => CalculatorLogic.Calculations.Calculate(expression));
        }

        [Fact]
        public void IncorrectInputTest4()
        {
            string expression = "5";
            Assert.Throws<ArgumentException>(() => CalculatorLogic.Calculations.Calculate(expression));
        }
    }
}
