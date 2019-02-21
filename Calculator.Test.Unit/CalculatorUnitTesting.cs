using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator = Unit_testing_Calculator.Calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTesting
    {

        private Unit_testing_Calculator.Calculator uut;


        [SetUp]
        public void SetUp()
        {
            uut = new Unit_testing_Calculator.Calculator();
        }

        [TestCase(8, 7, 15)]
        [TestCase(3, 7, 10)]
        [TestCase(3,2,5)]
        [TestCase(2,2,4)]
        [TestCase(-2,-2,-4)]
        [TestCase(4,-2,2)]
        [TestCase(-4, 2, -2)]
        public void Add_AddPositiveOrNegativeNumber_ReturnsSpecificAnswer(int a, int b, int result)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(6, 2, 4)]
        [TestCase(-2, -2, 0)]
        [TestCase(4, -2, 6)]
        [TestCase(-4, 2, -6)]
        public void Subtract_SubtractPositiveOrNegativeNumber_ReturnsSpecificAnswer(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(6, 2, 12)]
        [TestCase(-2, -2, 4)]
        [TestCase(4, -2, -8)]
        [TestCase(-4, 2, -8)]
        public void Multiply_MultiplyPositiveOrNegativeNumber_ReturnsSpecificAnswer(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 9)]
        [TestCase(6, 2, 36)]
        [TestCase(-2, 2, 4)]
        [TestCase(4, 2, 16)]
        [TestCase(-4, 2, 16)]
        public void Power_PowerPositiveOrNegativeNumber_ReturnsSpecificAnswer(int a, int b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }


        /*
        [Test]
        public void Add_Add2and4_Returns6()
        {
            var uut = new Unit_testing_Calculator.Calculator();

            Assert.That(uut.Add(2,4), Is.EqualTo(6));

        }

        [Test]
        public void Add_Subtract4and2_Returns2()
        {
            var uut = new Unit_testing_Calculator.Calculator();

            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));

        }

        [Test]
        public void Add_Multiply5and2_Returns2()
        {
            var uut = new Unit_testing_Calculator.Calculator();

            Assert.That(uut.Multiply(5, 2), Is.EqualTo(10));

        }

        [Test]
        public void Add_Power5and2_Returns2()
        {
            var uut = new Unit_testing_Calculator.Calculator();

            Assert.That(uut.Power(5, 2), Is.EqualTo(25));

        }
        */

    }
}
