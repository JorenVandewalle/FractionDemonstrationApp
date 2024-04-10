using FractionLibrary;

namespace FractionLibrary
{
    public class Fraction
    { 
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { if (value == 0)
                {
                    denominator = 1;
                }
                else
                {
                    denominator = value;
                } ; }
        }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
         
        public Fraction(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            if (Denominator != 0)
                this.Denominator = Denominator;
        }

        public Fraction Add(Fraction right)
        {
            int commonDenominator = Denominator * right.Denominator;
            int numeratorSum = (Numerator * right.Denominator) + (right.Numerator * Denominator);
            return new Fraction(numeratorSum, commonDenominator);
        }

        public Fraction Subtract(Fraction right)
        {
            int commonDenominator = Denominator * right.Denominator;
            int numeratorDifference = (Numerator * right.Denominator) - (right.Numerator * Denominator);
            return new Fraction(numeratorDifference, commonDenominator);
        }

        public Fraction Multiply(Fraction right)
        {
            int multipliedNumerator = Numerator * right.Numerator;
            int multipliedDenominator = Denominator * right.Denominator;
            return new Fraction(multipliedNumerator, multipliedDenominator);
        }

        public Fraction Divide(Fraction right)
        {
            int dividedNumerator = Numerator * right.Denominator;
            int dividedDenominator = Denominator * right.Numerator;
            return new Fraction(dividedNumerator, dividedDenominator);
        }

        public Fraction Reciprocal()
        {

            return new Fraction(Denominator, Numerator);
        }

        public Fraction Invert()
        {
            return new Fraction(-Numerator, Denominator);
        }

        public Fraction Simplify()
        {
            int GetGreatestCommonFactor(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                return a;
            }

            int gcf = GetGreatestCommonFactor(Numerator, Denominator);
            int simplifiedNumerator = Numerator / gcf;
            int simplifiedDenominator = Denominator / gcf;

            if (simplifiedDenominator < 0)
            {
                simplifiedNumerator *= -1;
                simplifiedDenominator *= -1;
            }

            return new Fraction(simplifiedNumerator, simplifiedDenominator);

        }

        public double Result()
        {
            return (double)Numerator / Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
