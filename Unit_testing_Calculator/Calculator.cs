using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_testing_Calculator
{
    public class Calculator
    {

        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;

            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;

            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;

            return Accumulator;
        }

        public double Power(double x, double exp)
        {
           
            double result = Math.Pow(x, exp);

            if (result.Equals(double.NaN))
            {
                throw new System.ArgumentOutOfRangeException("Result is not a number implying wrong usage");
            }
            else if (result.Equals(double.NegativeInfinity))
            {
                throw new System.ArgumentOutOfRangeException("Result is minus infinity");
            }
            else if (result.Equals(Double.PositiveInfinity))
            {
                throw new System.ArgumentOutOfRangeException("Result is plus infinity");
            }


            Accumulator = result;
            return Accumulator;
        }


        public double Divide(double dividen, double divisor)
        {

            if (divisor == 0)
            {
                throw new DivideByZeroException("Parameter 2");
            }

            Accumulator = dividen / divisor;

            return Accumulator;
        }

        
        public double Add(double addend)
        {
            return Add(Accumulator, addend);
        }

        public double Subtract(double subtractor)
        {
            return Subtract(Accumulator, subtractor);
        }

        public double Multiply(double multiplier)
        {
            return Multiply(Accumulator, multiplier);
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        public double Power(double exponent)
        {
            return Power(Accumulator, exponent);
        }
        
    }
}
