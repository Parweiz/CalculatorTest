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


        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            Assert.That(() => uut.Divide(3, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(9, 3, 3)]
        [TestCase(25, 5, 5)]
        [TestCase(144, 12, 12)]
        [TestCase(36, 6, 6)]
        [TestCase(81, 9, 9)]
        [TestCase(0, -3, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 7, 0)]
        [TestCase(1, 7, (1.0 / 7.0))]
        [TestCase(7, -3, -(7.0 / 3.0))]
        public void Divide_DividePositiveNumber_ReturnsSpecificAnswer(int a, int b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Add_2ParameterVersion_AccumulatorEqualsResult()
        {
            uut.Add(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(7));
        }

        [Test]
        public void Subtract_2ParameterVersion_AccumulatorEqualsResult()
        {
            uut.Subtract(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(-1));
        }

        [Test]
        public void Multiply_2ParameterVersion_AccumulatorEqualsResult()
        {
            uut.Multiply(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(12));
        }

        [Test]
        public void Divide_2ParameterVersion_AccumulatorEqualsResult()
        {
            uut.Divide(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(0.75));
        }

        [Test]
        public void Power_2ParameterVersion_AccumulatorEqualsResult()
        {
            uut.Power(2, 0.5);

            Assert.That(uut.Accumulator, Is.EqualTo(1.41).Within(0.005));
        }


        [Test]
        public void Add_1ParameterVersion_BuildsOnPreviousResult()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Add(4), Is.EqualTo(9));
        }
        [Test]
        public void Subtract_1ParameterVersion_BuildsOnPreviousResult()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Subtract(4), Is.EqualTo(1));
        }




        [Test]
        public void Power_1ParameterVersion_AccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Power(2);
            Assert.That(uut.Accumulator, Is.EqualTo(25));
        }

        [Test]
        public void Divide_1ParameterDivideByZero_ThrowsException()
        {
            uut.Add(2, 3);
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(-2, 0.5)]
        [TestCase(-2, (1.0 / 3.0))]
        [TestCase(0, -1)]
        public void Power_1ParameterIncorrectParameters_ThrowsException(double b, double exp)
        {
            uut.Add(b, 0);
            Assert.That(() => uut.Power(exp), Throws.TypeOf<ArgumentOutOfRangeException>());
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
