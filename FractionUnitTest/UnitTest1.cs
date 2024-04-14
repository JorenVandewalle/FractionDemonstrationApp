using Xunit;
using FractionLibrary;

namespace FractionUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            // positive
            Fraction leftFraction1 = new Fraction(1,2);
            Fraction rightFraction1 = new Fraction(3,4);

            Fraction result1 = leftFraction1.Add(rightFraction1);

            Fraction correctResult1 = new Fraction(5, 4);

            Assert.Equal(correctResult1.Simplify().ToString(), result1.Simplify().ToString()) ;

            // negative
            Fraction leftFraction2 = new Fraction(-3, 4);
            Fraction rightFraction2 = new Fraction(-5, 8);

            Fraction result2 = leftFraction2.Add(rightFraction2);

            Fraction correctResult2 = new Fraction(-11, 8);

            Assert.Equal(correctResult2.Simplify().ToString(), result2.Simplify().ToString());


            // zero
            Fraction leftFraction3 = new Fraction(-3, 4);
            Fraction rightFraction3 = new Fraction(0, 8);

            Fraction result3 = leftFraction3.Add(rightFraction3);

            Fraction correctResult3 = new Fraction(-3, 4);

            Assert.Equal(correctResult3.Simplify().ToString(), result3.Simplify().ToString());


            // zero and zero
            Fraction leftFraction4 = new Fraction(0, 4);
            Fraction rightFraction4 = new Fraction(0, 8);

            Fraction result4 = leftFraction4.Add(rightFraction4);

            Fraction correctResult4 = new Fraction(0,8);

            Assert.Equal(correctResult4.Simplify().ToString(), result4.Simplify().ToString());
        }

        [Fact]
        public void TestSubtract()
        {
            // positive
            Fraction leftFraction5 = new Fraction(1, 2);
            Fraction rightFraction5 = new Fraction(3, 4);

            Fraction result5 = leftFraction5.Subtract(rightFraction5);

            Fraction correctResult5 = new Fraction(-1, 4);

            Assert.Equal(correctResult5.Simplify().ToString(), result5.Simplify().ToString());

            // negative
            Fraction leftFraction6 = new Fraction(-3, 4);
            Fraction rightFraction6 = new Fraction(-5, 8);

            Fraction result6 = leftFraction6.Subtract(rightFraction6);

            Fraction correctResult6 = new Fraction(-1, 8);

            Assert.Equal(correctResult6.Simplify().ToString(), result6.Simplify().ToString());


            // zero
            Fraction leftFraction7 = new Fraction(-3, 4);
            Fraction rightFraction7 = new Fraction(0, 8);

            Fraction result7 = leftFraction7.Subtract(rightFraction7);

            Fraction correctResult7 = new Fraction(-3, 4);

            Assert.Equal(correctResult7.Simplify().ToString(), result7.Simplify().ToString());


            // zero and zero
            Fraction leftFraction8 = new Fraction(0, 4);
            Fraction rightFraction8 = new Fraction(0, 8);

            Fraction result8 = leftFraction8.Subtract(rightFraction8);

            Fraction correctResult8 = new Fraction(0, 8);

            Assert.Equal(correctResult8.Simplify().ToString(), result8.Simplify().ToString());
        }

        [Fact]
        public void TestMultiply()
        {
            // positive
            Fraction leftFraction9 = new Fraction(1, 2);
            Fraction rightFraction9 = new Fraction(3, 4);

            Fraction result9 = leftFraction9.Multiply(rightFraction9);

            Fraction correctResult9 = new Fraction(3, 8);

            Assert.Equal(correctResult9.Simplify().ToString(), result9.Simplify().ToString());

            // negative
            Fraction leftFraction10 = new Fraction(-3, 4);
            Fraction rightFraction10 = new Fraction(-5, 8);

            Fraction result10 = leftFraction10.Multiply(rightFraction10);

            Fraction correctResult10 = new Fraction(15, 32);

            Assert.Equal(correctResult10.Simplify().ToString(), result10.Simplify().ToString());


            // zero
            Fraction leftFraction11 = new Fraction(-3, 4);
            Fraction rightFraction11 = new Fraction(0, 8);

            Fraction result11 = leftFraction11.Multiply(rightFraction11);

            Fraction correctResult11 = new Fraction(0, 32);

            Assert.Equal(correctResult11.Simplify().ToString(), result11.Simplify().ToString());


            // zero and zero
            Fraction leftFraction12 = new Fraction(0, 4);
            Fraction rightFraction12 = new Fraction(0, 8);

            Fraction result12 = leftFraction12.Multiply(rightFraction12);

            Fraction correctResult12 = new Fraction(0, 8);

            Assert.Equal(correctResult12.Simplify().ToString(), result12.Simplify().ToString());
        }

        [Fact]
        public void TestDivide()
        {
            // positive
            Fraction leftFraction13 = new Fraction(1, 2);
            Fraction rightFraction13 = new Fraction(3, 4);

            Fraction result13 = leftFraction13.Divide(rightFraction13);

            Fraction correctResult13 = new Fraction(2, 3);

            Assert.Equal(correctResult13.Simplify().ToString(), result13.Simplify().ToString());

            // negative
            Fraction leftFraction14 = new Fraction(-3, 4);
            Fraction rightFraction14 = new Fraction(-5, 8);

            Fraction result14 = leftFraction14.Divide(rightFraction14);

            Fraction correctResult14 = new Fraction(6, 5);

            Assert.Equal(correctResult14.Simplify().ToString(), result14.Simplify().ToString());


            // zero
            Fraction leftFraction15 = new Fraction(-3, 4);
            Fraction rightFraction15 = new Fraction(0, 8);

            Fraction result15 = leftFraction15.Divide(rightFraction15);

            Fraction correctResult15 = new Fraction(-24, 4);

            Assert.Equal(correctResult15.Simplify().ToString(), result15.Simplify().ToString());


            // zero and zero
            Fraction leftFraction16 = new Fraction(0, 4);
            Fraction rightFraction16 = new Fraction(0, 8);

            Fraction result16 = leftFraction16.Divide(rightFraction16);

            Fraction correctResult16 = new Fraction(0, 4);

            Assert.Equal(correctResult16.Simplify().ToString(), result16.Simplify().ToString());
        }

        [Fact]
        public void TestReciprocal()
        {
            Fraction fractionTestReciprocal = new Fraction(1, 2);

            Fraction result = fractionTestReciprocal.Reciprocal();

            Fraction correctResult = new Fraction(2, 1);

            Assert.Equal(result.ToString(), correctResult.ToString());
        }

        [Fact]
        public void TestInvert()
        {
            // positive
            Fraction fractionTestInvert = new Fraction(1, 5);

            Fraction result = fractionTestInvert.Invert();

            Fraction correctResult = new Fraction(-1, 5);

            Assert.Equal(result.ToString(), correctResult.ToString());

            // negative
            Fraction fractionTestInvertNegative = new Fraction(-1, 5);
            
            Fraction resultNegative = fractionTestInvertNegative.Invert();

            Fraction correctResultNegative = new Fraction(1, 5);

            Assert.Equal(resultNegative.ToString(), correctResultNegative.ToString());

            // 0
            Fraction fractionTestInvertNull = new Fraction(0, 5);

            Fraction resultNull = fractionTestInvertNegative.Invert();

            Fraction correctResultNull = new Fraction(0, 5);

            Assert.Equal(resultNull.ToString(), correctResultNegative.ToString());
        }

        [Fact]
        public void TestResult()
        {
            // positive
            Fraction fractionTestResult = new Fraction(5, 10);

            double result = fractionTestResult.Result();

            Assert.Equal(0.5, result);

            // negative
            Fraction fractionTestResultNegative = new Fraction(-5, 10);

            double resultNegative = fractionTestResultNegative.Result();

            Assert.Equal(-0.5, resultNegative);

            // 0
            Fraction fractionTestResultNull = new Fraction(0, 10);

            double resultNull = fractionTestResultNull.Result();

            Assert.Equal(0, resultNull);
        }

        [Fact]
        public void TestSimplify()
        {
            // positive
            Fraction testPositive = new Fraction(5, 10);

            Fraction resultPositive = testPositive.Simplify();

            Fraction correctResultPositive = new Fraction(1, 2);

            Assert.Equal(resultPositive.ToString(), correctResultPositive.ToString());

            // negative
            Fraction testNegative = new Fraction(-5, 10);

            Fraction resultNegative = testNegative.Simplify();

            Fraction correctResultNegative = new Fraction(-1, 2);

            Assert.Equal(resultNegative.ToString(), correctResultNegative.ToString());

            // 0
            Fraction testNull = new Fraction(0, 10);

            Fraction resultNull = testNull.Simplify();

            Fraction correctResultNull = new Fraction(0, 1);

            Assert.Equal(resultNull.ToString(), correctResultNull.ToString());
        }

        [Fact]
        public void TestToString()
        {
            Fraction testToString = new Fraction(5, 10);

            string result = testToString.ToString();

            Assert.Equal("5/10", result);
        }
    }
}